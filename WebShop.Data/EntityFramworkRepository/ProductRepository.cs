using WebShop.Data.Interface;
using WebShop.Model.Models;

namespace WebShop.Data.EntityFramworkRepository
{ 
   

    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(IWebShopDbContextFactory dbFactory) : base(dbFactory)
        {
        }
    }
}