using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWebShop.Data.DbContext;
using TestWebShop.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace TestWebShop.Data.Repositories
{
    public class GoodTypeRepository : IGoodTypeRepository
    {
        private readonly IContextFactory _context;

        public GoodTypeRepository(IContextFactory context)
        {
            _context = context;
        }

        public async Task AddNotExists(List<GoodType> goodTypes)
        {
            var context = _context.GetContext();

            foreach (var item in goodTypes)
            {
                if (await context.GoodTypes.Where(g => g.Code == item.Code).FirstOrDefaultAsync() == null)
                {
                    context.GoodTypes.Add(item);
                }
            }

            await context.SaveChangesAsync();
        }

        public async Task<List<GoodType>> GetGoodTypes()
        {
            return await _context.GetContext().GoodTypes.ToListAsync();
        }
    }
}
