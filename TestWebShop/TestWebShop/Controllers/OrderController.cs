using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestWebShop.Converters;
using TestWebShop.Data.Repositories;

namespace TestWebShop.Controllers
{
    public class OrderController : Controller
    {
        private OrderRepository _orderRepository;
        private OrderConverter _orderConverter;

        public OrderController(OrderRepository orderRepository, OrderConverter orderConverter)
        {
            _orderRepository = orderRepository;
            _orderConverter = orderConverter;
        }

        [HttpGet]
        public async Task<IActionResult> CreateOrder()
        {
            var goodsFromDB = await _orderRepository.GetGoods();
            var goodTypesFromDB = await _orderRepository.GetGoodTypes();
            var producersFromDB = await _orderRepository.GetProducers();
            var orderModel = _orderConverter.ToModel(goodsFromDB, goodTypesFromDB, producersFromDB);
            return View(orderModel);
        }

        //[HttpPost]
        //public async Task<IActionResult> BuyOrder()
        //{

        //}

        //[HttpGet]
        //public async Task<IActionResult> OrderHistory()
        //{

        //}
    }
}