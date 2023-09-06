using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVCTaskmanager.Models;

namespace MVCTaskmanager.identity
{
    public class ApplicationDbContext: IdentityDbContext<ApplicationUser, IdentityRole, String>
    {
        public ApplicationDbContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<ClientLocation> ClientLocations { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<IdentityRole> ApplicationRoles { get; set; }
        public DbSet<country> Countries { get; set; }
        public DbSet<skills> Skills { get; set; }
        public DbSet<TaskPriority> TaskPriorities { get; set; }
        public DbSet<TaskStat> TaskStatuses { get; set; }
        public DbSet<TheTask> TheTasks { get; set; }
        public DbSet<TaskStatusDetail> TaskStatusDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ClientLocation>().HasData(
                new ClientLocation() { ClientLocationID = 1, ClientLocationName = "Boston"},
                 new ClientLocation() { ClientLocationID = 2, ClientLocationName = "New Delhi" },
                  new ClientLocation() { ClientLocationID = 3, ClientLocationName = "New Jersy" },
                   new ClientLocation() { ClientLocationID = 4, ClientLocationName = "New York" },
                    new ClientLocation() { ClientLocationID = 5, ClientLocationName = "London" },
                     new ClientLocation() { ClientLocationID = 6, ClientLocationName = "Tokyo" }
            );

            modelBuilder.Entity<Project>().HasData(
                new Project() { ProjectID=1, ProjectName="Hospital Management System", DateOfStart=Convert.ToDateTime("2017-8-1"), Active=true, ClientLocationID=2, Status="In Force", TeamSize=14},
                new Project() { ProjectID = 2, ProjectName = "Reporting Tool", DateOfStart = Convert.ToDateTime("2018-8-16"), Active = true, ClientLocationID = 2, Status = "Support", TeamSize = 81 }
            );

            modelBuilder.Entity<country>().HasData(
                new country() { CountryID = 1, CountryName = "China"},
                new country() { CountryID = 2, CountryName = "United States"},
                new country() { CountryID = 3, CountryName = "Brazil" },
                new country() { CountryID = 4, CountryName = "Nigeria"},
                new country() { CountryID = 5, CountryName = "Pakistan" },
                new country() { CountryID = 6, CountryName = "Bangladash" },
                new country() { CountryID = 7, CountryName = "Russia" },
                new country() { CountryID = 8, CountryName = "Croatia" },
                new country() { CountryID = 9, CountryName = "Mexico" },
                new country() { CountryID = 10, CountryName = "France" }
            );

            modelBuilder.Entity<TaskPriority>().HasData(
                new TaskPriority() { TaskPriorityID = 1, TaskPriorityName = "Urgent" },
                new TaskPriority() { TaskPriorityID = 2, TaskPriorityName = "Normal" },
                new TaskPriority() { TaskPriorityID = 3, TaskPriorityName = "Below Normal" },
                new TaskPriority() { TaskPriorityID = 4, TaskPriorityName = "Low" }
            );

            modelBuilder.Entity<TaskStat>().HasData(
                new TaskStat() { TaskStatusID = 1, TaskStatusName = "Holding"},
                new TaskStat() { TaskStatusID = 2, TaskStatusName = "Prioritised" },
                new TaskStat() { TaskStatusID = 3, TaskStatusName = "Started" },
                new TaskStat() { TaskStatusID = 4, TaskStatusName = "Finished" },
                new TaskStat() { TaskStatusID = 5, TaskStatusName = "Reverted" }
            );
        }

    }
}
