using WebShop.Data.Interface;
using WebShop.Model.Models;

namespace WebShop.Data.EntityFramworkRepository
{
 
    public class MenuRepository : GenericRepository<Menu>, IMenuRepository
    {
        public MenuRepository(IWebShopDbContextFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}