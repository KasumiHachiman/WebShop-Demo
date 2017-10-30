

using WebShop.Data.Interface;
using WebShop.Model.Models;

namespace WebShop.Data.EntityFramworkRepository
{

    public class PageRepository : GenericRepository<Page>, IPageRepository
    {
        public PageRepository(IWebShopDbContextFactory dbFactory) : base(dbFactory)
        {
        }
    }
}