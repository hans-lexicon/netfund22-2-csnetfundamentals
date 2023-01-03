using _03_GettersAndSetters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_GettersAndSetters.Examples
{
    internal class Example_PropFullGetSet
    {

        public void Example1()
        {
            var contact = new Person_PropFullGetSet();

            // SET
            contact.FirstName = " Hans";
            contact.LastName = " Mattin-Lassei";
            contact.Email = "a@a.store";
        
            // GET
            Console.WriteLine(contact.FirstName);
            Console.WriteLine(contact.LastName);
            Console.WriteLine(contact.Email);
        }
    }
}
