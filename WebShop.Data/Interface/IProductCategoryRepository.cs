using System.Collections.Generic;
using WebShop.Model.Models;

namespace WebShop.Data.Interface
{
    public interface IProductCategoryRepository : IRepository<ProductCategory>
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }
}