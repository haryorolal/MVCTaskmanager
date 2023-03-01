using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MVCTaskmanager.Models
{
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }

        [DisplayFormat(DataFormatString = "d/M/yyyy")]
        public DateTime DateOfStart { get; set; }
        public int? TeamSize { get; set; }
        public bool Active { get; set; }
        public string Status { get; set; }
        public int ClientLocationID { get; set; }

        [ForeignKey("ClientLocationID")]
        public virtual ClientLocation? ClientLocation { get; set; }

    }
    /*
    public class TaskManagerDbContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            base.OnConfiguring(optionBuilder);
            //optionBuilder.UseSqlServer("data source=LAPTOP-CG29M1EU\\SQLEXPRESS; integrated security=yes;User ID=sa;Password=Incorrect22_;initial catalog=TaskManager;TrustServerCertificate=True;");
            optionBuilder.UseSqlServer("Server=LAPTOP-CG29M1EU\\SQLEXPRESS;Initial Catalog=TaskManager;Integrated Security=False;User ID=sa;Password=Incorrect22_;MultipleActiveResultSets=True;TrustServerCertificate=True;");

        }
    }*/
}
