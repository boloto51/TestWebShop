using Microsoft.EntityFrameworkCore;
using TestWebShop.Data.Entities;

namespace TestWebShop.Data.DbContext
{
    public class DataContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Good> Goods { get; set; }
        public DbSet<GoodType> GoodTypes { get; set; }
        public DbSet<Producer> Producers { get; set; }
    }
}
