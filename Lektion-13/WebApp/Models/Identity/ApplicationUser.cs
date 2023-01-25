using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.Identity
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [PersonalData]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [PersonalData]
        public string LastName { get; set; } = string.Empty;
    }
}
