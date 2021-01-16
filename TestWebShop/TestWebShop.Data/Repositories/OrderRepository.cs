using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestWebShop.Data.DbContext;
using TestWebShop.Data.Entities;

namespace TestWebShop.Data.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly IContextFactory _context;

        public OrderRepository(IContextFactory context)
        {
            _context = context;
        }
    }
}
