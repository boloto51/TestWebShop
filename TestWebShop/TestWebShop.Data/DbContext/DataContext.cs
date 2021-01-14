using System;
using System.Collections.Generic;
using System.Text;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Good>().HasKey(a => new { a.Id });
            modelBuilder.Entity<GoodType>().HasKey(a => new { a.Id });
            modelBuilder.Entity<Producer>().HasKey(a => new { a.Id });
            modelBuilder.Entity<GoodType>().HasMany(s => s.Goods);
            modelBuilder.Entity<Producer>().HasMany(s => s.Goods);
        }
    }
}
