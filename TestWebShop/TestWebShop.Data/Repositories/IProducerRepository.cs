using System.Collections.Generic;
using System.Threading.Tasks;
using TestWebShop.Data.Entities;

namespace TestWebShop.Data.Repositories
{
    public interface IProducerRepository
    {
        Task AddNotExists(List<Producer> producers);
    }
}
