using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlattsAPI.Models
{
    public class ProductDataHistory
    {
        public int ProductDataHistoryId { get; set; }
        public int ProductId { get; set; }
        public float StartPrice { get; set; }
        public DateTime HistoryDate { get; set; }
        public float EndPrice { get; set; }
        public float DayHighPrice { get; set; }
        public float DayLowPrice { get; set; }
    }
}
