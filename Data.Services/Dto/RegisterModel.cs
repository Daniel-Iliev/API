using System.ComponentModel.DataAnnotations;

namespace Data.Services.Dto
{
    public class RegisterModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
