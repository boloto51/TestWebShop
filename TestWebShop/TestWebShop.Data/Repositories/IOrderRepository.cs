﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestWebShop.Data.Entities;

namespace TestWebShop.Data.Repositories
{
    public interface IOrderRepository
    {
        Task<List<Good>> GetGoods();
        Task<List<GoodType>> GetGoodTypes();
        Task<List<Producer>> GetProducers();
    }
}