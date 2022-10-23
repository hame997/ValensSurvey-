using Valens_Survey_Management_API.Enums;

namespace ValensSurvey.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public Roles Role { get; set; }

    }
}
