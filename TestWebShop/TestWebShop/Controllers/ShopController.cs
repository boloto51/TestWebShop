﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
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
                return RedirectToAction("CreateOrder", "Order");
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}