using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWebShop.Models.Goods;

namespace TestWebShop.Converters
{
    public class GoodTypeConverter : IGoodTypeConverter
    {
        public List<Data.Entities.GoodType> ToEntity(Goods goods)
        {
            var goodsTypeConvert = new List<Data.Entities.GoodType>();

            foreach (var item in goods)
            {
                goodsTypeConvert.Add(new Data.Entities.GoodType
                {
                    Name = item.GoodType.Name,
                    Code = item.GoodType.Code
                });
            }

            return goodsTypeConvert;
        }
    }
}
