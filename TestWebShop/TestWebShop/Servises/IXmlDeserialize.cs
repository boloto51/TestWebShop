using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWebShop.Models.Goods;

namespace TestWebShop.Servises
{
    public interface IXmlDeserialize
    {
        Goods GetGoods(IFormFile file);
    }
}
