using System.Collections.Generic;
using System.Linq;
using WebShop.Data.Interface;
using WebShop.Model.Models;

namespace WebShop.Data.EntityFramworkRepository
{
    public class PostRepository : GenericRepository<Post>, IPostRepository
    {
        public PostRepository(IWebShopDbContextFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<Post> GetAllByTag(string tag, int pageIndex, int pageSize, out int totalRow)
        {
            var query = from p in DbContext.Posts
                        join pt in DbContext.PostTags
                        on p.ID equals pt.PostID
                        where pt.TagID == tag && p.Status
                        orderby p.CreatedDate descending
                        select p;
            totalRow = query.Count();
            //count moi run query va dem so dong
            query = query.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            //skip rong muon lay va take tu dong 0 den page index
            return query;
        }
    }
}