﻿using _03_Interfaces_Demo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Interfaces_Demo.Models.Products
{
    internal class Tv : IProduct
    {
        public int Inches { get; set; }
        public string Vendor { get; set; }
    }
}
