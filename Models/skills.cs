using MVCTaskmanager.identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCTaskmanager.Models
{
    public class skills
    {
        [Key]
        public int skillsID { get; set; }
        public string skillsName { get; set; }
        public string skillsLevel { get; set; }
        public string? Id { get; set; }

        [ForeignKey("Id")]
        public virtual ApplicationUser? ApplicationUser { get; set; }
    }
}
