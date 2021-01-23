using System.Collections.Generic;
using System.Threading.Tasks;
using TestWebShop.Data.Entities;

namespace TestWebShop.Data.Repositories
{
    public interface IOrderRepository
    {
        public Task AddNewOrderToDB(List<Order> orders);
    }
}
