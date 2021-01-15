using System.Collections.Generic;
using System.Linq;
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
                // уникальный ли артикул и имя?
                // только добавлять в базу, или обновлять тоже?
                if (context.Goods.Where(g => g.Articul == item.Articul).FirstOrDefaultAsync() == null
                    &&
                    context.Goods.Where(g => g.Name == item.Name).FirstOrDefaultAsync() == null)
                {
                    context.Goods.Add(item);
                }
            }

            await context.SaveChangesAsync();
        }
    }
}
