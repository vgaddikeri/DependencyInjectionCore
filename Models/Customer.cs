using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionCore.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public int ServiceID { get; set; }
        public string ServiceName { get; set; }
        public string City { get; set; }
        public string PickupDate { get; set; }
    }
}
