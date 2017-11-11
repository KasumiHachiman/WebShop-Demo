using WebShop.Data.Interface;
using WebShop.Model.Models;

namespace WebShop.Data.EntityFramworkRepository
{
    public class SupportOnlineRepository : GenericRepository<SupportOnline>, ISupportOnlineRepository
    {
        public SupportOnlineRepository(IWebShopDbContextFactory dbFactory) : base(dbFactory)
        {
        }
    }
}