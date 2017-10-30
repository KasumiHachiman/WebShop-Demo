using System.Collections.Generic;
using WebShop.Model.Models;

namespace WebShop.Data.Interface
{
    public interface IPostRepository : IRepository<Post>
    {
        IEnumerable<Post> GetAllByTag(string tag, int pageIndex, int pageSize, out int totalRow);
    }
}