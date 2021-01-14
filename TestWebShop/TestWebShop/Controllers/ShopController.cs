using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Xml.Serialization;
using TestWebShop.Models.Goods;
using TestWebShop.Servises;

namespace TestWebShop.Controllers
{
    public class ShopController : Controller
    {
        private readonly IXmlDeserialize _xmlDeserialize;

        public ShopController(IXmlDeserialize xmlDeserialize)
        {
            _xmlDeserialize = xmlDeserialize;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Upload(IFormFile file)
        {
            try
            {
                var goods = _xmlDeserialize.GetGoods(file);
                // await Manager(goods)
                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}