﻿using Microsoft.EntityFrameworkCore;

namespace TestWebShop.Data.DbContext
{
    public class ContextFactory : IContextFactory
    {
        private readonly DbContextOptions<DataContext> _options;

        public ContextFactory(DbContextOptions<DataContext> options)
        {
            this._options = options;
        }

        public DataContext GetContext()
        {
            return new DataContext(_options);
        }
    }
}
