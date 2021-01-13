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

namespace TestWebShop.Controllers
{
    public class ShopController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Upload(IFormFile file)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Good));
            var goods = ((Good)serializer.Deserialize(file.OpenReadStream()));
            return View();
        }
    }
}