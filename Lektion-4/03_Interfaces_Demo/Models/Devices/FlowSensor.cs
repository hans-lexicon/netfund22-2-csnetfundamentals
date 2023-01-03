using _03_Interfaces_Demo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Interfaces_Demo.Models.Devices
{
    internal class FlowSensor : IDevice
    {
        public float FlowValue { get; set; }
        public bool IsRunning { get; set; }
        public string DeviceId { get; set; } = null!;
    }
}
