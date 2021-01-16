using System.Collections.Generic;
using TestWebShop.Data.Entities;

namespace TestWebShop.Models
{
    public class OrderModel
    {
        public List<Good> goods { get; set; }
        public List<GoodType> goodType { get; set; }
        public List<Producer> producers { get; set; }

        //public int Id { get; set; }
        //public string Name { get; set; }
        //public double Value { get; set; }
        //public string Articul { get; set; }
        //public string Currency { get; set; }
        //public string GoodTypeName { get; set; }
        //public string GoodTypeCode { get; set; }
        //public string ProducerName { get; set; }
        //public string ProducerCode { get; set; }
    }
}
