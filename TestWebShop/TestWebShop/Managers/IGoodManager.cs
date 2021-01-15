using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWebShop.Models.Goods;

namespace TestWebShop.Managers
{
    public interface IGoodManager
    {
        public Task AddRecordsToTable(Goods goods);
    }
}
