using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Interfaces.Interfaces
{
    internal interface IBillingInformation
    {
        string StreetName { get; set; }
        string PostalCode { get; set; }
        string City { get; set; }
        string Conuntry { get; set; }
    }
}
