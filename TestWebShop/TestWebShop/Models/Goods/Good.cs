using System;
using System.Xml.Serialization;

namespace TestWebShop.Models.Goods
{
    [Serializable()]
    public class Good
    {
        [XmlElement(ElementName = "Producer")]
        public Producer Producer { get; set; }
        [XmlElement(ElementName = "GoodType")]
        public GoodType GoodType { get; set; }
        [XmlAttribute("Name")]
        public string Name { get; set; }
        [XmlAttribute("Value")]
        public double Value { get; set; }
        [XmlAttribute("Articul")]
        public string Articul { get; set; }
        [XmlAttribute("Currency")]
        public string Currency { get; set; }
    }
}
