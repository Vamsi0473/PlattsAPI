using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlattsAPI.Models
{
    public class ProductSubscription
    {
        public int ProductSubscriptionId { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public int SubscriptionType { get; set; }
        public bool Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
