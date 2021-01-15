using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWebShop.Models.Goods;

namespace TestWebShop.Converters
{
    public interface IProducerConverter
    {
        public List<Data.Entities.Producer> ToEntity(Goods goods);
    }
}
