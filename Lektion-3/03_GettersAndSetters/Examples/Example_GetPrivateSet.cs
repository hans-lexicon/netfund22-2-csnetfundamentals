using _03_GettersAndSetters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_GettersAndSetters.Examples
{
    internal class Example_GetPrivateSet
    {
        public void Example1(string lastName)
        {

            var contact = new Person_GetPrivateSet();

            // SET
            contact.FirstName = "Hans";
            contact.LastName = lastName;
            contact.SetEmailAddress("domain.com");
            contact.GeneratePassword("taddaa");



            // GET
            //Console.WriteLine($"{contact.FirstName} {contact.LastName}");
            //var fullName = $"{contact.FirstName} {contact.LastName}";
            //Console.WriteLine(contact.Email);
            Console.WriteLine(contact.PasswordHash);

            Console.ReadKey();
        }
    }
}
