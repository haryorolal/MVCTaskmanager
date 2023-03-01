using MVCTaskmanager.Models;

namespace MVCTaskmanager.viewModels
{
    public class SignUpViewModel
    {
        public PersonFullName PersonName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string DateOfBirth { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public int CountryID { get; set; }
        public bool ReceiveNewsLetters { get; set; }
        public List<skills> Skills { get; set; }
    }

    public class PersonFullName
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}
