using System.Collections.Generic;
using WebShop.Data.Interface;
using WebShop.Model.Models;
using System.Linq;

namespace WebShop.Data.EntityFramworkRepository
{
  

    public class ProductCategoryRepository : GenericRepository<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(IWebShopDbContextFactory dbFactory)
            : base(dbFactory)
        {
        }

        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.ProductCategories.Where(x => x.Alias == alias);
        }
    }
}