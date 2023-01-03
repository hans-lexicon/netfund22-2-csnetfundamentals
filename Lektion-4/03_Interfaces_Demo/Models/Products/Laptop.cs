using _03_Interfaces_Demo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Interfaces_Demo.Models.Products
{

    internal class Laptop : IProduct, IComputer
    {
        public string Vendor { get; set; }
        public string Model { get; set; }
        public string CPU { get; set; }
        public int RAM { get; set; }
    }
}
