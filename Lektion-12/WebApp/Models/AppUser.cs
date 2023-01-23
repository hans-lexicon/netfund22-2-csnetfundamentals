using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class AppUser : IdentityUser
    {
        public AppUser()
        {

        }

        public AppUser(string firstName, string lastName, string email)
        {
            FirstName= firstName;
            LastName= lastName;
            Email= email;
            UserName = email;
        }


        [Required]
        [PersonalData]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [PersonalData]
        public string LastName { get; set; } = string.Empty;
    }
}
