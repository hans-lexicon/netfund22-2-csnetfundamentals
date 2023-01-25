using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.Forms
{
    public class LoginFormModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "E-mail Address")]
        public string Email { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; } = false;
    }
}
