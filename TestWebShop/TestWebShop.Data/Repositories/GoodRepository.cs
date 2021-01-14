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
    public class GoodRepository : IGoodRepository
    {
        private readonly IContextFactory _context;

        public GoodRepository(IContextFactory context)
        {
            _context = context;
        }

        public async Task Add(Good good)
        {
            var context = _context.GetContext();
            context.Goods.Add(good);
            await context.SaveChangesAsync();
        }


        public async Task AddRange(List<Good> good)
        {
            var context = _context.GetContext();
            context.Goods.AddRange(good);
            await context.SaveChangesAsync();
        }

        public async Task Update(Good good)
        {
            var context = _context.GetContext();
            context.Goods.Update(good);
            await context.SaveChangesAsync();
        }

        public async Task UpdateRange(List<Good> good)
        {
            var context = _context.GetContext();
            context.Goods.UpdateRange(good);
            await context.SaveChangesAsync();
        }

        public async Task Remove(string Id)
        {
            var context = _context.GetContext();
            var toDelete = await context.Goods.FirstOrDefaultAsync(g => g.Id == Id);
            context.Goods.Remove(toDelete);
            await context.SaveChangesAsync();
        }

        public async Task RemoveRange(List<Good> good)
        {
            var context = _context.GetContext();
            context.Goods.RemoveRange(good);
            await context.SaveChangesAsync();
        }
    }
}
