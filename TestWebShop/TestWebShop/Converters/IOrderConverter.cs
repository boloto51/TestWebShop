using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWebShop.Data.Entities;
using TestWebShop.Models;

namespace TestWebShop.Converters
{
    public interface IOrderConverter
    {
        public List<OrderModel> ToModel(List<Good> goods,
            List<GoodType> goodTypes, List<Producer> producers);
    }
}
