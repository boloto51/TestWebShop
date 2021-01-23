using System.Collections.Generic;
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
            var context = _context.GetContext();

            foreach (var item in orders)
            {
                context.Orders.Add(item);
            }

            await context.SaveChangesAsync();
        }
    }
}
