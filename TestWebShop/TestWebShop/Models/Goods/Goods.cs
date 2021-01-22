using System.Collections.Generic;
using System.Xml.Serialization;

namespace TestWebShop.Models.Goods
{
    [XmlRoot("Goods")]
    public class Goods : List<Good>
    {

    }
}
