using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TestWebShop.Models.Goods
{
    [XmlRoot("Goods")]
    public class Goods : List<Good>
    {

    }
}
