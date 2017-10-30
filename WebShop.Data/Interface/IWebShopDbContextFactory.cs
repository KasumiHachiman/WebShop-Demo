namespace WebShop.Data.Interface
{
    public interface IWebShopDbContextFactory
    {
        WebShopDbContext Init();
    }
}