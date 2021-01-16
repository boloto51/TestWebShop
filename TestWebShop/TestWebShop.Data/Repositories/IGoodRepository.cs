using System.Collections.Generic;
using TestWebShop.Data.Entities;
using System.Threading.Tasks;

namespace TestWebShop.Data.Repositories
{
    public interface IGoodRepository
    {
        Task AddNotExists(List<Good> goods);
        Task<List<Good>> GetGoods();
    }
}
