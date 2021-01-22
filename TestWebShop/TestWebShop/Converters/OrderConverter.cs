using System.Collections.Generic;
using TestWebShop.Data.Entities;
using TestWebShop.Models;

namespace TestWebShop.Converters
{
    public class OrderConverter : IOrderConverter
    {
        public OrderModel ToModel(List<Good> goods, 
            List<GoodType> goodTypes, List<Producer> producers)
        {
            var orderModel = new OrderModel
            {
                goods = goods,
                goodTypes = goodTypes,
                producers = producers
            };

            return orderModel;
        }
    }
}
