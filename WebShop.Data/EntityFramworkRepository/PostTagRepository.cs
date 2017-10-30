

using WebShop.Data.Interface;
using WebShop.Model.Models;

namespace WebShop.Data.EntityFramworkRepository
{ 


    public class PostTagRepository : GenericRepository<PostTag>, IPostTagRepository
    {
        public PostTagRepository(IWebShopDbContextFactory dbFactory) : base(dbFactory)
        {
        }
    }
}