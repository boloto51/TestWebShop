using System.Collections.Generic;
using System.Threading.Tasks;
using TestWebShop.Data.DbContext;
using TestWebShop.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace TestWebShop.Data.Repositories
{
    public class GoodRepository : IGoodRepository
    {
        private readonly IContextFactory _context;

        public GoodRepository(IContextFactory context)
        {
            _context = context;
        }

        public async Task AddNotExists(List<Good> goods)
        {
            var context = _context.GetContext();

            foreach (var item in goods)
            {
                if (await context.Goods.FirstOrDefaultAsync(g => g.Articul == item.Articul &&
                g.Name == item.Name) == null)
                {
                    context.Goods.Add(item);
                }
            }

            await context.SaveChangesAsync();
        }

        public async Task<List<Good>> GetGoods()
        {
            return await _context.GetContext().Goods.ToListAsync();
        }
    }
}
