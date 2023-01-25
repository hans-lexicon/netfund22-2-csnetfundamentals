using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.Forms
{
    public class ContactFormModel
    {
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [Display(Name = "E-mail Address")]
        public string Email { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Comments")]
        public string Comments { get; set; } = string.Empty;
    }
}
