using System.ComponentModel.DataAnnotations;

namespace FixxoWebApp.Models
{
    public class LoginForm
    {
        [Required]
        [EmailAddress]
        [Display(Name = "E-mail Address")]
        public string Email { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; } = string.Empty;

        public string ReturnUrl { get; set; } = "/";
    }
}
