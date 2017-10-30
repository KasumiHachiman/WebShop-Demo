using WebShop.Data.Interface;

namespace WebShop.Data.EntityFramworkRepository
{
    public class SupportOnlineRepository : GenericRepository<SupportOnline>, ISupportOnlineRepository
    {
        public SupportOnlineRepository(IWebShopDbContextFactory dbFactory) : base(dbFactory)
        {
        }
    }
}