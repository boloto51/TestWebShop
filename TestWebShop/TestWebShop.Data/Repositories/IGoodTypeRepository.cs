using System;
using System.Collections.Generic;
using System.Text;
using TestWebShop.Data.Entities;
using System.Threading.Tasks;

namespace TestWebShop.Data.Repositories
{
    public interface IGoodTypeRepository
    {
        Task Add(GoodType goodtype);
        Task AddRange(List<GoodType> goodtype);
        Task Update(GoodType goodtype);
        Task UpdateRange(List<GoodType> goodtype);
        Task Remove(string Id);
        Task RemoveRange(List<GoodType> goodtype);
    }
}
