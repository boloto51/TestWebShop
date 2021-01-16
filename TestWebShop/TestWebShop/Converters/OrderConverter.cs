using System.Collections.Generic;
using System.Linq;
using TestWebShop.Data.Entities;
using TestWebShop.Models;

namespace TestWebShop.Converters
{
    public class OrderConverter : IOrderConverter
    {
        public List<OrderModel> ToModel(List<Good> goods, 
            List<GoodType> goodTypes, List<Producer> producers)
        {
            var orderModel = new List<OrderModel>();

            foreach (var item in goods)
            {
                orderModel.Add(new OrderModel
                {
                    Id = item.Id,
                    Name = item.Name,
                    Value = item.Value,
                    Articul = item.Articul,
                    Currency = item.Currency,
                    GoodTypeName = goodTypes.Where(g => g.Code == item.GoodTypeCode).Select(g => g.Name).ToString(),
                    GoodTypeCode = item.GoodTypeCode,
                    ProducerName = producers.Where(p => p.Code == item.ProducerCode).Select(p => p.Name).ToString(),
                    ProducerCode = item.ProducerCode
                });
            }

            return orderModel;
        }
    }
}
