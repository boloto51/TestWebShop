using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWebShop.Models.Goods;

namespace TestWebShop.Converters
{
    public class ProducerConverter : IProducerConverter
    {
        public List<Data.Entities.Producer> ToEntity(Goods goods)
        {
            var producerConvert = new List<Data.Entities.Producer>();

            foreach (var item in goods)
            {
                producerConvert.Add(new Data.Entities.Producer
                {
                    Name = item.Producer.Name,
                    Code = item.Producer.Code
                });
            }

            return producerConvert;
        }
    }
}
