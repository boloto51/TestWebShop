using System;
using System.Collections.Generic;
using System.Text;
using TestWebShop.Data.DbContext;

namespace TestWebShop.Data.DbContext
{
    public interface IContextFactory
    {
        DataContext GetContext();
    }
}
