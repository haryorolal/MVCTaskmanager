using System.ComponentModel.DataAnnotations;

namespace MVCTaskmanager.Models
{
    public class country
    {
        [Key]
        public int CountryID { get; set; }
        public string CountryName { get; set; }
    }
}
