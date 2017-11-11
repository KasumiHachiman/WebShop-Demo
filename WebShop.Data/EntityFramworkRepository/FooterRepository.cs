
using WebShop.Data.Interface;
using WebShop.Model.Models;

namespace WebShop.Data.EntityFramworkRepository
{
   
    public class FooterRepository : GenericRepository<Footer>, IFooterRepository
    {
        public FooterRepository(IWebShopDbContextFactory
            dbFactory) : base(dbFactory)
        {
        }
    }
}