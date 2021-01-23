using System;
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

        public List<Order> ToModel(OrderCreateModel orderCreateModel, string guid)
        {
            var orders = new List<Order>();
            DateTime date = DateTime.Now;

            foreach (var item in orderCreateModel.Goods)
            {
                orders.Add(new Order
                {
                    OrderGuid = guid,
                    GoodId = item.id,
                    GoodCount = item.count,
                    GoodPrice = item.price,
                    OrderDate = date
                });
            }

            return orders;
        }
    }
}

