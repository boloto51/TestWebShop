using TestWebShop.Data.DbContext;

namespace TestWebShop.Data.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly IContextFactory _context;

        public OrderRepository(IContextFactory context)
        {
            _context = context;
        }
    }
}
