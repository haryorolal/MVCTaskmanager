using MVCTaskmanager.identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MVCTaskmanager.Models
{
    public class TheTask
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TaskID { get; set; }
        public string TaskName { get; set; }
        public string Description { get; set; }
        public DateTime TaskCreatedOn { get; set; }
        public int? ProjectID { get; set; }
        public string? TaskCreatedBy { get; set; }
        public string? AssignedTo { get; set; }
        public int? TaskPriorityID { get; set; }
        public DateTime LastUpdateOn { get; set; }
        public string TaskCurrentStatus { get; set; }
        public int TaskCurrentStatusID { get; set; }

        [NotMapped]
        public string CreatedOnString { get; set; }

        [NotMapped]
        public string? LastUpdatedOnString { get; set; }

        [ForeignKey("ProjectID")]
        public virtual Project Project { get; set; }

        [ForeignKey("TaskCreatedBy")]
        public virtual ApplicationUser TaskCreatedByUser { get; set; }

        [ForeignKey("AssignedTo")]
        public virtual ApplicationUser AssignedToUser { get; set; }

        [ForeignKey("TaskPriorityID")]
        public virtual TaskPriority TaskPriority { get; set; }

        //public virtual IList<TaskStatusDetail> TaskStatusDetails { get; set; }
        public virtual ICollection<TaskStatusDetail> TaskStatusDetails { get; set; }

        public class GroupedTask
        {
            public string TaskStatusName { get; set; }
            public List<TheTask> Tasks { get; set; }
        }


    }
}
