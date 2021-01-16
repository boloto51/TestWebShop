using System.Collections.Generic;
using TestWebShop.Models.Goods;

namespace TestWebShop.Converters
{
    public class GoodConverter : IGoodConverter
    {
        public List<Data.Entities.Good> ToEntity(Goods goods)
        {
            var goodsConvert = new List<Data.Entities.Good>();

            foreach (var item in goods)
            {
                goodsConvert.Add(new Data.Entities.Good
                {
                    Name = item.Name,
                    Value = item.Value,
                    Articul = item.Articul,
                    Currency = item.Currency,
                    GoodTypeCode = item.GoodType.Code,
                    ProducerCode = item.Producer.Code
                });
            }

            return goodsConvert;
        }
    }
}
