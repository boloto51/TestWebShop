using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWebShop.Models.Goods;

namespace TestWebShop.Converters
{
    public interface IGoodConverter
    {
        public List<Data.Entities.Good> ToEntity(Goods goods);
    }
}
