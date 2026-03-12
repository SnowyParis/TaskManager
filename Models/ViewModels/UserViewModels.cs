using System.ComponentModel.DataAnnotations;

namespace TaskManager.Models.ViewModels
{
    public class UserViewModels
    {
        public class LoginModel
        {
            [Required]
            [UIHint("email")] //check if email is a valid email
            public string? Email { get; set; }

            [Required]
            [UIHint("password")] //password will be written as asterisks
            public string? Password { get; set; }

            public string ReturnUrl { get; set; } = "/"; //url of unauthorized page before login authentication
        }

        public class SignupModel
        {
            [Required]
            [Display(Name = "User name")]
            public string? UserName { get; set; }

            [Required]
            [Display(Name = "E-mail")]
            [EmailAddress]
            public string? Email { get; set; }

            [Required]
            [DataType(DataType.Password)] //Indicate that password options specified in Program.cs must be used.
            public string? Password { get; set; }

            [Compare("Password", ErrorMessage = "Passwords must match")]
            [Display(Name = "Confirm Password")]
            [DataType(DataType.Password)]
            public string? ConfirmPassword { get; set; }

            //public IFormFile AvatarImage { get; set; }
        }
    }
}
