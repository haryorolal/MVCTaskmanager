using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCTaskmanager.identity;
using MVCTaskmanager.Models;
using static MVCTaskmanager.Models.TheTask;

namespace MVCTaskmanager.Controllers
{
    public class TaskController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly ApplicationUserManager _applicationUserManager;

        public TaskController(ApplicationDbContext db, ApplicationUserManager applicationUserManager)
        {
            this._db = db;
            this._applicationUserManager = applicationUserManager;
        }

        [HttpGet]
        [Route("/api/tasks")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public IActionResult Get()
        {
            string currentUserId = User.Identity.Name;
            List<GroupedTask> grouppedTasks = new List<GroupedTask>();
            List<TaskStat> taskStatuses = _db.TaskStatuses.ToList();
            List<TheTask> theTasks = _db.TheTasks
            .Include(temp => temp.AssignedToUser)
            .Include(temp => temp.Project).ThenInclude(temp => temp.ClientLocation)
            .Include(temp => temp.TaskStatusDetails)
            .Include(temp => temp.TaskPriority)
            .Include(temp => temp.LastUpdatedOnString)
            .Where(temp => temp.TaskCreatedBy == currentUserId || temp.AssignedTo == currentUserId)
            .OrderBy(temp => temp.TaskPriorityID)
            .ThenByDescending(temp => temp.LastUpdatedOnString).ToList();

            foreach (TheTask task in theTasks)
            {
                task.CreatedOnString = task.TaskCreatedOn.ToString("dd/MM/yyyy");
                task.LastUpdatedOnString = task.LastUpdateOn.ToString("dd/MM/yyyy");
                task.TaskStatusDetails = task.TaskStatusDetails.OrderByDescending(temp => temp.TaskStatusDetailID).ToList();

                foreach (var taskstatusDetails in task.TaskStatusDetails)
                {
                    taskstatusDetails.StatusUpdateDateTimeString = taskstatusDetails.StatusUpdateDateTime.ToString("dd/MM/yyyy");
                }
            }

            foreach (TaskStat taskStatus in taskStatuses)
            {
                GroupedTask groupedTask = new GroupedTask();
                groupedTask.TaskStatusName = taskStatus.TaskStatusName;
                groupedTask.Tasks = theTasks.Where(temp => temp.TaskCurrentStatus == taskStatus.TaskStatusName).ToList();

                if (groupedTask.Tasks.Count > 0)
                {
                    grouppedTasks.Add(groupedTask);
                }

            }

            return Ok(grouppedTasks);

        }

        [HttpPost]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Route("/api/createtask")]
        public IActionResult Post([FromBody] TheTask task)
        {
            task.Project = null;
            task.TaskCreatedByUser = null;
            task.AssignedToUser = null;
            task.TaskPriority = null;
            task.TaskStatusDetails = null;
            task.TaskCreatedOn = DateTime.Now;
            task.LastUpdateOn = DateTime.Now;
            task.TaskCurrentStatus = "Holding";
            task.TaskCurrentStatusID = 1;
            task.CreatedOnString = task.TaskCreatedOn.ToString("dd/MM/yyyy");
            task.LastUpdatedOnString = task.LastUpdateOn.ToString("dd/MM/yyyy");
            task.TaskCreatedBy = User.Identity.Name;
            
            _db.TheTasks.Add(task);
            _db.SaveChanges();

            TaskStatusDetail taskStatusDetail = new TaskStatusDetail();
            taskStatusDetail.TaskID = task.TaskID;
            taskStatusDetail.UserID = task.TaskCreatedBy;
            taskStatusDetail.TaskStatusID = 1;
            taskStatusDetail.StatusUpdateDateTime = DateTime.Now;
            taskStatusDetail.TaskStatus = 0; //null
            taskStatusDetail.User = null;
            taskStatusDetail.Description = "Task Created";
            _db.TaskStatusDetails.Add(taskStatusDetail);
            _db.SaveChanges();

            TheTask existingTask = _db.TheTasks.Where(temp => temp.TaskID == task.TaskID).FirstOrDefault();
            return Ok(existingTask);
        }
    }
}
