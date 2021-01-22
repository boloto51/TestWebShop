using System.Collections.Generic;
using TestWebShop.Data.Entities;
using TestWebShop.Models;

namespace TestWebShop.Converters
{
    public interface IOrderConverter
    {
        public OrderModel ToModel(List<Good> goods,
            List<GoodType> goodTypes, List<Producer> producers);
    }
}
