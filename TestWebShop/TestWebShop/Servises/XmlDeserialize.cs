using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TestWebShop.Models.Goods;

namespace TestWebShop.Servises
{
    public class XmlDeserialize : IXmlDeserialize
    {
        public Goods GetGoods(IFormFile file)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Goods));
            var goods = (Goods)serializer.Deserialize(file.OpenReadStream());
            return goods;
        }
    }
}
