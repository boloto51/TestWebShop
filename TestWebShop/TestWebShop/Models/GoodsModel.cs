using System.Text.Json.Serialization;

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
