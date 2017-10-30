using WebShop.Data.Interface;
using WebShop.Model.Models;

namespace WebShop.Data.EntityFramworkRepository
{
    public class TagRepository : GenericRepository<Tag>, ITagRepository
    {
        public TagRepository(IWebShopDbContextFactory dbFactory) : base(dbFactory)
        {
        }
    }
}