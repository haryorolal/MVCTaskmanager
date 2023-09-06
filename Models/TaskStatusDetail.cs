using System;
using System.Collections.Generic;
using MVCTaskmanager.identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCTaskmanager.Models
{
    public class TaskStatusDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TaskStatusDetailID { get; set; }
        public int TaskID { get; set; } 
        public int TaskStatusID { get; set; }
        public string UserID { get; set; }
        public string Description { get; set; }
        public DateTime StatusUpdateDateTime { get; set; }

        [NotMapped]
        public string StatusUpdateDateTimeString { get; set; }

        [ForeignKey("TaskStatusID")]
        public virtual TaskStatus TaskStatus { get; set; }

        [ForeignKey("UserID")]
        public virtual ApplicationUser User { get; set; }


    }
}
