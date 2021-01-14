using System;
using System.Collections.Generic;
using System.Text;
using TestWebShop.Data.Entities;
using System.Threading.Tasks;

namespace TestWebShop.Data.Repositories
{
    public interface IGoodRepository
    {
        Task Add(Good good);
        Task AddRange(List<Good> good);
        Task Update(Good good);
        Task UpdateRange(List<Good> good);
        Task Remove(string Id);
        Task RemoveRange(List<Good> good);
    }
}
