using _03_GettersAndSetters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_GettersAndSetters.Examples
{
    internal class Example_Get
    {
        public void Example1()
        {

            var contact = new Person_Get();

            // SET
            contact.FirstName = "Hans";
            contact.LastName = "Mattin-Lassei";

            // GET
            Console.WriteLine(contact.DisplayName);
            Console.WriteLine(contact.Email);
        }

    }
}
