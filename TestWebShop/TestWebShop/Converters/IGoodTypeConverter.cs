using System.Collections.Generic;
using TestWebShop.Models.Goods;

namespace TestWebShop.Converters
{
    public interface IGoodTypeConverter
    {
        public List<Data.Entities.GoodType> ToEntity(Goods goods);
    }
}
