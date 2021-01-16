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
using TestWebShop.Managers;

namespace TestWebShop.Controllers
{
    public class ShopController : Controller
    {
        private readonly IXmlDeserialize _xmlDeserialize;
        private IGoodManager _goodManager;

        public ShopController(IXmlDeserialize xmlDeserialize, IGoodManager goodManager)
        {
            _xmlDeserialize = xmlDeserialize;
            _goodManager = goodManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            try
            {
                var goods = _xmlDeserialize.GetGoods(file);
                await _goodManager.AddRecordsToTable(goods);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}