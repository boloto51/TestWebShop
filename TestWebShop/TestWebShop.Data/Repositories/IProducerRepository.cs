using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestWebShop.Data.Entities;

namespace TestWebShop.Data.Repositories
{
    public interface IProducerRepository
    {
        Task Add(Producer producer);
        Task AddRange(List<Producer> producer);
        Task Update(Producer producer);
        Task UpdateRange(List<Producer> producer);
        Task Remove(string Id);
        Task RemoveRange(List<Producer> producer);
    }
}
