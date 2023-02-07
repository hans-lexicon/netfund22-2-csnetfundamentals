using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace FixxoWebApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [Display(Name = "First Name")]
        [PersonalData]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Last Name")]
        [PersonalData]
        public string LastName { get; set; } = string.Empty;


        [Display(Name = "Street Name")]
        [PersonalData]
        public string StreetName { get; set; } = string.Empty;

        [Display(Name = "Postal Code")]
        [PersonalData]
        public string PostalCode { get; set; } = string.Empty;

        [Display(Name = "City")]
        [PersonalData]
        public string City { get; set; } = string.Empty;
    }
}
