using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWebShop.Models
{
    public class OrderFinishModel
    {
        public string OrderGuid { get; set; }
        public int GoodId { get; set; }
        public int GoodCount { get; set; }
        public double GoodPrice { get; set; }
        public DateTime Date { get; set; }
    }
}
