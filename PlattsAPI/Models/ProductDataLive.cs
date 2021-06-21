using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlattsAPI.Models
{
    public class ProductDataLive
    {
        public int ProductDataLiveId { get; set; }
        public int ProductId { get; set; }
        public float StartPrice { get; set; }
        public DateTime CurrentTime { get; set; }
        public float CurrentPrice { get; set; }
        public float DayHighPrice { get; set; }
        public float DayLowPrice { get; set; }
    }
}
