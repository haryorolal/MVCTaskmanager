using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVCTaskmanager.identity;
using MVCTaskmanager.Models;

namespace MVCTaskmanager.Controllers
{
    public class TaskPriorityController : Controller
    {
        private ApplicationDbContext _db;

        public TaskPriorityController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        [Route("api/taskpriorities")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public List<TaskPriority> Get()
        {
            List<TaskPriority> taskPriorities = _db.TaskPriorities.ToList();
            return taskPriorities;
        }

        [HttpGet]
        [Route("api/taskpriorities/searchByTaskPriorityid/{TaskPriorityID}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public IActionResult GetByTaskPriorityID(int TaskPriorityID)
        {
            TaskPriority taskPriority = _db.TaskPriorities.Where(temp => temp.TaskPriorityID == TaskPriorityID).FirstOrDefault();
            if(taskPriority != null)
            {
                return Ok(taskPriority);
            }
            else
            {
                return NoContent();
            }
        }

        [HttpPost]
        [Route("api/taskpriorities")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public TaskPriority Post([FromBody] TaskPriority taskPriority)
        {
            _db.TaskPriorities.Add(taskPriority);
            _db.SaveChanges();

            TaskPriority existingTaskPriority = _db.TaskPriorities.Where(temp => temp.TaskPriorityID == taskPriority.TaskPriorityID).FirstOrDefault();
            return taskPriority;
        }

        [HttpPut]
        [Route("api/taskpriorities")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public TaskPriority Put([FromBody] TaskPriority task)
        {
            TaskPriority existingTaskPriority = _db.TaskPriorities.Where(temp => temp.TaskPriorityID == task.TaskPriorityID).FirstOrDefault();
            if(existingTaskPriority != null)
            {
                existingTaskPriority.TaskPriorityName = task.TaskPriorityName;
                _db.SaveChanges();
                return existingTaskPriority;
            }
            else
            {
                return null;
            }
        }

        [HttpDelete]
        [Route("api/taskpriorities")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public int Delete(int TaskPriorityID)
        {
            TaskPriority existingTaskPriority = _db.TaskPriorities.Where(temp => temp.TaskPriorityID == TaskPriorityID).FirstOrDefault();
            if(existingTaskPriority != null)
            {
                _db.TaskPriorities.Remove(existingTaskPriority);
                _db.SaveChanges();
                return TaskPriorityID;
            }
            else
            {
                return -1;
            }
        }
    }
}
