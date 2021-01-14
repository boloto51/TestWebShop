using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
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
