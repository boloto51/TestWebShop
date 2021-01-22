using System;
using System.Xml.Serialization;

namespace TestWebShop.Models.Goods
{
    [Serializable()]
    public class Producer
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }
        [XmlAttribute("Code")]
        public string Code { get; set; }
    }
}
