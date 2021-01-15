using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWebShop.Data.DbContext;
using TestWebShop.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace TestWebShop.Data.Repositories
{
    public class ProducerRepository : IProducerRepository
    {
        private readonly IContextFactory _context;

        public ProducerRepository(IContextFactory context)
        {
            _context = context;
        }

        public async Task AddNotExists(List<Producer> producers)
        {
            var context = _context.GetContext();

            foreach (var item in producers)
            {
                if (context.Producers.Where(p => p.Code == item.Code).FirstOrDefaultAsync() == null)
                {
                    context.Producers.Add(item);
                }                
            }

            await context.SaveChangesAsync();
        }        
    }
}
