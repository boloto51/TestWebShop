using System;
using System.Collections.Generic;
using System.Collections.Immutable;
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

        public async Task Add(Producer producer)
        {
            var context = _context.GetContext();
            context.Producers.Add(producer);
            await context.SaveChangesAsync();
        }


        public async Task AddRange(List<Producer> producer)
        {
            var context = _context.GetContext();
            context.Producers.AddRange(producer);
            await context.SaveChangesAsync();
        }

        public async Task Update(Producer producer)
        {
            var context = _context.GetContext();
            context.Producers.Update(producer);
            await context.SaveChangesAsync();
        }

        public async Task UpdateRange(List<Producer> producer)
        {
            var context = _context.GetContext();
            context.Producers.UpdateRange(producer);
            await context.SaveChangesAsync();
        }

        public async Task Remove(string Id)
        {
            var context = _context.GetContext();
            var toDelete = await context.Producers.FirstOrDefaultAsync(p => p.Id == Id);
            context.Producers.Remove(toDelete);
            await context.SaveChangesAsync();
        }

        public async Task RemoveRange(List<Producer> producer)
        {
            var context = _context.GetContext();
            context.Producers.RemoveRange(producer);
            await context.SaveChangesAsync();
        }
    }
}
