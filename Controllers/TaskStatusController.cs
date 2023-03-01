using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVCTaskmanager.identity;
using MVCTaskmanager.Models;

namespace MVCTaskmanager.Controllers
{
    public class TaskStatusController : Controller
    {

        private ApplicationDbContext _db;

        public TaskStatusController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        [Route("api/taskstatuses")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public List<TaskStat> Get()
        {
            List<TaskStat> taskStatuses = _db.TaskStatuses.ToList();
            return taskStatuses;
        }

        [HttpGet]
        [Route("api/taskstatuses/searchByTaskStatusesID/{TaskStatusID}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public IActionResult GetByTaskStatusID(int TaskStatusID)
        {
            TaskStat taskstatus = _db.TaskStatuses.Where(temp => temp.TaskStatusID == TaskStatusID).FirstOrDefault();
            if(taskstatus != null)
            {
                return Ok(taskstatus);
            }
            else
            {
                return NoContent();
            }
        }

        [HttpPost]
        [Route("api/taskstatuses")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public TaskStat Post([FromBody] TaskStat taskStatus)
        {
            _db.TaskStatuses.Add(taskStatus);
            _db.SaveChanges();

            TaskStat existingtaskStatus = _db.TaskStatuses.Where(temp => temp.TaskStatusID == taskStatus.TaskStatusID).FirstOrDefault();
            return taskStatus;
        }

        [HttpPut]
        [Route("api/taskstatuses")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public TaskStat Put([FromBody] TaskStat taskstatus)
        {
            TaskStat existingtaskStatus = _db.TaskStatuses.Where(temp => temp.TaskStatusID == taskstatus.TaskStatusID).FirstOrDefault();
            if(existingtaskStatus != null)
            {
                existingtaskStatus.TaskStatusName = taskstatus.TaskStatusName;
                _db.SaveChanges();
                return existingtaskStatus;
            }
            else
            {
                return null;
            }
        }

        [HttpDelete]
        [Route("api/taskstatuses")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public int Delete(int taskstatusID)
        {
            TaskStat existingTaskStatus = _db.TaskStatuses.Where(temp => temp.TaskStatusID == taskstatusID).FirstOrDefault();
            if(existingTaskStatus != null)
            {
                _db.TaskStatuses.Remove(existingTaskStatus);
                _db.SaveChanges();
                return taskstatusID;
            }
            else
            {
                return -1; 
            }
            

        }
    }
}
