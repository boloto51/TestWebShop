using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
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

        public async Task AddNewOrderToDB(List<Order> orders)
        {
            if (orders.Count > 0)
            {
                var context = _context.GetContext();
                context.Orders.AddRange(orders);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<Order>> Get(string guid)
        {
            return await _context.GetContext().Orders.Where(o => o.OrderGuid == guid).ToListAsync();
        }
    }
}
