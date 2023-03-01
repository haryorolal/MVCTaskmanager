using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCTaskmanager.identity;
using MVCTaskmanager.Models;
using MVCTaskmanager.viewModels;

namespace TaskManagerMVC.Controllers
{
    //[Authorize]
    public class ProjectController : Controller
    {
        private ApplicationDbContext _db;
        public ProjectController(ApplicationDbContext db)
        {
            this._db = db;
        }


        [HttpGet]
        [Route("api/projects")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)] // Antiforgery
        public IActionResult Get()
        {
            //Thread.Sleep(1000); //delay of 1 second
            List<Project> projects = _db.Projects.Include("ClientLocation").ToList();

            List<ProjectViewModel> projectViewModel = new List<ProjectViewModel>();
            foreach (var project in projects)
            {
                projectViewModel.Add(new ProjectViewModel()
                {
                    ProjectID = project.ProjectID,
                    ProjectName = project.ProjectName,
                    TeamSize = project.TeamSize,
                    DateOfStart = project.DateOfStart.ToString("dd/MM/yyyy"),
                    Active = project.Active,
                    ClientLocation = project.ClientLocation,
                    ClientLocationID = project.ClientLocationID,
                    Status = project.Status

                });
            }

            return Ok(projectViewModel);
        }

        [HttpGet]
        [Route("api/projects/search/{searchby}/{searchtext}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)] // Antiforgery
        public IActionResult Search(string searchBy, string searchText)
        {           
            List<Project> projects = null;  

            if(searchBy == "ProjectID")
            {
                projects = _db.Projects.Include("ClientLocation").Where(s => s.ProjectID.ToString().Contains(searchText)).ToList();
            }
            else if(searchBy == "ProjectName")
            {
                projects = _db.Projects.Include("ClientLocation").Where(s => s.ProjectName.Contains(searchText)).ToList();
            }
            else if(searchBy == "DateOfStart")
            {
                projects = _db.Projects.Include("ClientLocation").Where(s => s.DateOfStart.ToString().Contains(searchText)).ToList();
            }
            else if(searchBy == "TeamSize")
            {
                projects = _db.Projects.Include("ClientLocation").Where(s => s.TeamSize.ToString().Contains(searchText)).ToList();
            }

            List<ProjectViewModel> projectViewModel = new List<ProjectViewModel>();
            foreach (var project in projects)
            {
                projectViewModel.Add(new ProjectViewModel()
                {
                    ProjectID = project.ProjectID,
                    ProjectName = project.ProjectName,
                    TeamSize = project.TeamSize,
                    DateOfStart = project.DateOfStart.ToString("dd/MM/yyyy"),
                    Active = project.Active,
                    ClientLocation = project.ClientLocation,
                    ClientLocationID = project.ClientLocationID,
                    Status = project.Status

                });
            }

            return Ok(projectViewModel);
        }

        [HttpGet]
        [Route("api/projects/searchbyprojectid/{ProjectID}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)] // Antiforgery
        public IActionResult GetProjectById(int ProjectID)
        {
            
            Project project = _db.Projects.Include("ClientLocation").Where(temp => temp.ProjectID == ProjectID).FirstOrDefault();

            
            if (project != null)
            {
                ProjectViewModel projectViewModel = new ProjectViewModel()
                {
                    ProjectID = project.ProjectID,
                    ProjectName = project.ProjectName,
                    TeamSize = project.TeamSize,
                    DateOfStart = project.DateOfStart.ToString("dd/MM/yyyy"),
                    Active = project.Active,
                    ClientLocation = project.ClientLocation,
                    ClientLocationID = project.ClientLocationID,
                    Status = project.Status

                };
                return Ok(projectViewModel);
            }
            else
            {
                return Ok();
            }

            

            
        }

        [HttpPost]
        [Route("api/projects")]        
        [Authorize]
        [ValidateAntiForgeryToken] // Antiforgery
        public IActionResult Post([FromBody]Project project)
        {
            project.ClientLocation = null;
            _db.Projects.Add(project);
            _db.SaveChanges();

            Project existingProject = _db.Projects.Include("ClientLocation").Where(temp => temp.ProjectID == project.ProjectID).FirstOrDefault();

            ProjectViewModel projectViewModel = new ProjectViewModel()
            {
                ProjectID = existingProject.ProjectID,
                ProjectName = existingProject.ProjectName,
                TeamSize = existingProject.TeamSize,
                DateOfStart =  existingProject.DateOfStart.ToString("dd/MM/yyyy"),
                Active = existingProject.Active,
                ClientLocation = existingProject.ClientLocation,
                ClientLocationID = existingProject.ClientLocationID,
                Status = existingProject.Status
            };

            return Ok(projectViewModel);

        }

        [HttpPut]
        [Route("api/projects")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)] // Antiforgery
        public IActionResult Put([FromBody] Project project)
        {
            Project existingProject = _db.Projects.Where(x => x.ProjectID == project.ProjectID).FirstOrDefault();
            if(existingProject != null)
            {
                existingProject.ProjectName = project.ProjectName;
                existingProject.DateOfStart = project.DateOfStart;
                existingProject.TeamSize = project.TeamSize;
                existingProject.DateOfStart = project.DateOfStart;
                existingProject.Active = project.Active;
                existingProject.ClientLocationID = project.ClientLocationID;
                existingProject.Status = project.Status;
                existingProject.ClientLocation = null;
                _db.SaveChanges();

                Project existingProject2 = _db.Projects.Include("ClientLocation").Where(temp => temp.ProjectID == project.ProjectID).FirstOrDefault();

                ProjectViewModel projectViewModel = new ProjectViewModel()
                {
                    ProjectID = existingProject2.ProjectID,
                    ProjectName = existingProject2.ProjectName,
                    TeamSize = existingProject2.TeamSize,
                    DateOfStart = existingProject2.DateOfStart.ToString("dd/MM/yyyy"),
                    Active = existingProject2.Active,
                    ClientLocation = existingProject2.ClientLocation,
                    ClientLocationID = existingProject2.ClientLocationID,
                    Status = existingProject2.Status
                };

                return Ok(projectViewModel);
            }
            else
            {
                return null;
            }
        }

        [HttpDelete]
        [Route("api/projects")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)] // Antiforgery
        public int Delete(int ProjectID)
        {
            var existingProject = _db.Projects.Where(del => del.ProjectID == ProjectID).FirstOrDefault();
           if(existingProject != null)
            {
                _db.Projects.Remove(existingProject);
                _db.SaveChanges();
                return ProjectID;
            }
            else
            {
                return -1;
            }
        }
    }
}
