using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TestWebShop.Models
{
    public class OrderCreateModel
    {
        [JsonPropertyName("Goods")]
        public List<GoodsModel> Goods { get; set; }
    }
}
