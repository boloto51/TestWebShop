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
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Order>().HasKey(a => new { a.GoodId, a.OrderGuid });
        }
    }
}
