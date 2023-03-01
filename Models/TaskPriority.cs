using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCTaskmanager.Models
{
    public class TaskPriority
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TaskPriorityID { get; set; }
        public string TaskPriorityName { get; set; }
    }
}
