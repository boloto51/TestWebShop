namespace TestWebShop.Data.DbContext
{
    public interface IContextFactory
    {
        DataContext GetContext();
    }
}
