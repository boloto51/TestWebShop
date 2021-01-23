﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestWebShop.Converters;
using TestWebShop.Data.Entities;
using TestWebShop.Data.Repositories;
using TestWebShop.Models;

namespace TestWebShop.Controllers
{
    public class OrderController : Controller
    {
        private IGoodRepository _goodRepository;
        private IGoodTypeRepository _goodTypeRepository;
        private IProducerRepository _producerRepository;
        private IOrderRepository _orderRepository;
        private IOrderConverter _orderConverter;

        public OrderController(IGoodRepository goodRepository, IGoodTypeRepository goodTypeRepository,
            IOrderRepository orderRepository, IProducerRepository producerRepository, IOrderConverter orderConverter)
        {
            _goodRepository = goodRepository;
            _goodTypeRepository = goodTypeRepository;
            _producerRepository = producerRepository;
            _orderRepository = orderRepository;
            _orderConverter = orderConverter;
        }

        [HttpGet]
        public async Task<IActionResult> CreateOrder()
        {
            var goodsFromDB = await _goodRepository.GetGoods();
            var goodTypesFromDB = await _goodTypeRepository.GetGoodTypes();
            var producersFromDB = await _producerRepository.GetProducers();
            var orderModel = _orderConverter.ToModel(goodsFromDB, goodTypesFromDB, producersFromDB);
            return View(orderModel);
        }

        [HttpPost]
        public async Task<RedirectToActionResult> CreateOrder([FromBody]OrderCreateModel orderCreateModel)
        {
            try
            {
                string guid = Guid.NewGuid().ToString("N");
                List<Order> orders = _orderConverter.ToModel(orderCreateModel, guid);
                await _orderRepository.AddNewOrderToDB(orders);
                //await _orderRepository.Get(guid);
                return RedirectToAction("CheckOrder", "Order", new { guid });
                //return RedirectToAction("CheckOrder", "Order", new { orders });
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //[HttpGet]
        //public async Task<IActionResult> CheckOrder(List<Order> orders)
        //{
        //    return View(orders);
        //}

        [HttpGet]
        public async Task<IActionResult> CheckOrder(string guid)
        {
            List<Order> orders = await _orderRepository.Get(guid);
            return View(orders);
        }
    }
}