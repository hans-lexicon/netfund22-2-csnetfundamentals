using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _03_GettersAndSetters.Models
{
    internal class Person_GetPrivateSet
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; private set; } = null!;
        public byte[] PasswordHash { get; private set; } = null!;
        
        public void GeneratePassword(string password)
        {
            using var hmac = new HMACSHA512();
            PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
        }





        public void SetEmailAddress(string domain)
        {
            // Email = "hans.mattin-lassei@domain.com";
            Email = $"{FirstName.ToLower()}.{LastName.ToLower()}@{domain.ToLower()}";
        }

    }
}
