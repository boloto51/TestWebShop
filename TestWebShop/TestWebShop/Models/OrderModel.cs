using System.Collections.Generic;
using TestWebShop.Data.Entities;

namespace TestWebShop.Models
{
    public class OrderModel
    {
        public List<Good> goods { get; set; }
        public List<GoodType> goodTypes { get; set; }
        public List<Producer> producers { get; set; }
    }
}
