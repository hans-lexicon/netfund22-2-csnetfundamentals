﻿using _03_Interfaces_Demo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Interfaces_Demo.Models.Products
{
    internal class StationaryComputer : IComputer
    {
        public string CPU { get; set; }
        public string Model { get; set; }
        public int RAM { get; set; }
        public string Vendor { get; set; }
    }
}
