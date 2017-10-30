
using WebShop.Data.Interface;
using WebShop.Model.Models;

namespace WebShop.Data.EntityFramworkRepository
{

    public class MenuGroupRepository : GenericRepository<MenuGroup>, IMenuGroupRepository
    {
        public MenuGroupRepository(IWebShopDbContextFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
