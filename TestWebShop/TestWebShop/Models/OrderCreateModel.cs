using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TestWebShop.Models
{
    public class OrderCreateModel
    {
        [JsonPropertyName("Goods")]
        public List<GoodsModel> Goods { get; set; }
    }
}
