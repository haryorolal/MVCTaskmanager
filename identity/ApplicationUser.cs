using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;


namespace MVCTaskmanager.identity
{
    public class ApplicationUser: IdentityUser<String>
    {
        [NotMapped]
        public string Token { get; set; }

        [NotMapped]
        public string Role { get; set; }
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        [DisplayFormat(DataFormatString = "d/M/yyyy")]
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public int CountryID { get; set; }
        public bool ReceiveNewsLetters { get; set; }
    }

    
}
