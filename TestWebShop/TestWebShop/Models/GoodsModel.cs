using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TestWebShop.Models
{
    public class GoodsModel
    {
        [JsonPropertyName("id")]
        public int id { get; set; }
        [JsonPropertyName("count")]
        public int count { get; set; }
        [JsonPropertyName("price")]
        public double price { get; set; }
    }
}
