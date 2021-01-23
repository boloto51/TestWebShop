using System.Data.Entity;
using System.Threading.Tasks;
using TestWebShop.Data.DbContext;
using TestWebShop.Data.Entities;

namespace TestWebShop.Test.Context
{
    internal class FakeContext //: IDataContext
    {
        public FakeContext()
        {
            //Goods = new FakeDbSet<Good>();
            //GoodTypes = new FakeDbSet<GoodType>();
            //Producers = new FakeDbSet<Producer>();
        }

        public void Dispose()
        {
        }

        public DbSet<Good> Goods { get; set; }
        public DbSet<GoodType> GoodTypes { get; set; }
        public DbSet<Producer> Producers { get; set; }

        public async Task<int> SaveChangesAsync()
        {
            return 1;
        }

        public int SaveChanges()
        {
            return 1;
        }
    }
}