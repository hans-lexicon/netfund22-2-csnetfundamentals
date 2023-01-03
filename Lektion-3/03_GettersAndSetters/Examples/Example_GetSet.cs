using _03_GettersAndSetters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_GettersAndSetters.Examples
{
    internal class Example_GetSet
    {
        public void Example1(string lastName)
        {

            var contact = new Person_GetSet();

            // SET
            contact.FirstName = "Hans";
            contact.LastName = lastName;
            contact.Email= "hans@domain.com";

            // GET
            Console.WriteLine($"{contact.FirstName} {contact.LastName}");
            var fullName = $"{contact.FirstName} {contact.LastName}";
        }

        public void Example2(string lastName)
        {
            // SET
            var contact = new Person_GetSet
            {
                FirstName = "Hans",
                LastName = lastName,
                Email = "hans@domain.com"
            };

            // GET
            Console.WriteLine($"{contact.FirstName} {contact.LastName}");
            var fullName = $"{contact.FirstName} {contact.LastName}";
        }
    }
}
