using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlattsAPI.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string EmailId { get; set; }
        public string Country { get; set; }
        public int ContactNumber { get; set; }
        public string Company { get; set; }
    }
}
