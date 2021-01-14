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
    public class GoodTypeRepository : IGoodTypeRepository
    {
        private readonly IContextFactory _context;

        public GoodTypeRepository(IContextFactory context)
        {
            _context = context;
        }

        public async Task Add(GoodType goodtype)
        {
            var context = _context.GetContext();
            context.GoodTypes.Add(goodtype);
            await context.SaveChangesAsync();
        }


        public async Task AddRange(List<GoodType> goodtype)
        {
            var context = _context.GetContext();
            context.GoodTypes.AddRange(goodtype);
            await context.SaveChangesAsync();
        }

        public async Task Update(GoodType goodtype)
        {
            var context = _context.GetContext();
            context.GoodTypes.Update(goodtype);
            await context.SaveChangesAsync();
        }

        public async Task UpdateRange(List<GoodType> goodtype)
        {
            var context = _context.GetContext();
            context.GoodTypes.UpdateRange(goodtype);
            await context.SaveChangesAsync();
        }

        public async Task Remove(string Id)
        {
            var context = _context.GetContext();
            var toDelete = await context.GoodTypes.FirstOrDefaultAsync(g => g.Id == Id);
            context.GoodTypes.Remove(toDelete);
            await context.SaveChangesAsync();
        }

        public async Task RemoveRange(List<GoodType> goodtype)
        {
            var context = _context.GetContext();
            context.GoodTypes.RemoveRange(goodtype);
            await context.SaveChangesAsync();
        }
    }
}
