using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_AccessModifiers.DifferentProject.Models
{
    public class Customer
    {
        public string Public { get; set; } = null!;
        internal string Internal { get; set; } = null!;
        private string Private { get; set; } = null!;



        public void SetEmail(string email)
        {
            Public = email;
            Internal = email;
            Private = email;
        }
    }
}
