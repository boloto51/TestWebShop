using System.Collections.Generic;
using TestWebShop.Data.Entities;
using System.Threading.Tasks;

namespace TestWebShop.Data.Repositories
{
    public interface IGoodTypeRepository
    {
        Task AddNotExists(List<GoodType> goodTypes);
    }
}
