﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCTaskmanager.Models
{
    public class TaskStat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TaskStatusID { get; set; }
        public string TaskStatusName { get; set; }
    }
}
