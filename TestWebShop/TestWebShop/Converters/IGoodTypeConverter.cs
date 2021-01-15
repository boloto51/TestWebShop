using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWebShop.Models.Goods;

namespace TestWebShop.Converters
{
    public interface IGoodTypeConverter
    {
        public List<Data.Entities.GoodType> ToEntity(Goods goods);
    }
}
