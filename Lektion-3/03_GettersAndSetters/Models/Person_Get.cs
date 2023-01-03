using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_GettersAndSetters.Models
{
    internal class Person_Get
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { 
            get 
            {
                return $"{FirstName.ToLower()}.{LastName.ToLower()}@domain.com";
            } 
        }

        public string DisplayName => $"{FirstName} {LastName}"; 
    }
}
