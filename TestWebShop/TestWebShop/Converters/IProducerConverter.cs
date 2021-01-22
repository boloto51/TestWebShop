using System.Collections.Generic;
using TestWebShop.Models.Goods;

namespace TestWebShop.Converters
{
    public interface IProducerConverter
    {
        public List<Data.Entities.Producer> ToEntity(Goods goods);
    }
}
