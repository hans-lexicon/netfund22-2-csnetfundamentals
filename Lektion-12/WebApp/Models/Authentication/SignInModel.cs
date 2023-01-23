using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.Authentication
{
    public class SignInModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "E-mail Adress")]
        public string Email { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; } = string.Empty;
    }
}
