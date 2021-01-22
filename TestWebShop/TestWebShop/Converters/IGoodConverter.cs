using System.Collections.Generic;
using TestWebShop.Models.Goods;

namespace TestWebShop.Converters
{
    public interface IGoodConverter
    {
        public List<Data.Entities.Good> ToEntity(Goods goods);
    }
}
