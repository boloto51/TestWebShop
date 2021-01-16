using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestWebShop.Data.DbContext;
using TestWebShop.Data.Entities;

namespace TestWebShop.Data.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly IContextFactory _context;

        public OrderRepository(IContextFactory context)
        {
            _context = context;
        }

        public async Task<List<Good>> GetGoods()
        {
            return await _context.GetContext().Goods.ToListAsync();
        }

        public async Task<List<GoodType>> GetGoodTypes()
        {
            return await _context.GetContext().GoodTypes.ToListAsync();
        }

        public async Task<List<Producer>> GetProducers()
        {
            return await _context.GetContext().Producers.ToListAsync();
        }
    }
}
