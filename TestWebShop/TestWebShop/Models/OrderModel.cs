namespace TestWebShop.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public string Articul { get; set; }
        public string Currency { get; set; }
        public string GoodTypeName { get; set; }
        public string GoodTypeCode { get; set; }
        public string ProducerName { get; set; }
        public string ProducerCode { get; set; }
    }
}
