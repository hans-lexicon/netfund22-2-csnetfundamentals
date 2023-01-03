using _03_Interfaces_Demo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Interfaces_Demo.Models.Devices
{
    internal class Fan : IDevice
    {
        public bool IsRunning { get; set; }
        public string DeviceId { get; set; } = null!;
    }
}
