using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlattsAPI.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string ProductType { get; set; }
        public string CreatedDate { get; set; }
        public bool Active { get; set; }

    }
}
