using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace TestWebShop.Models.Goods
{
    public class Good
    {
        public Producer Producer { get; set; }
        public GoodType GoodType { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public string Articul { get; set; }
        public string Currency { get; set; }
    }
}
