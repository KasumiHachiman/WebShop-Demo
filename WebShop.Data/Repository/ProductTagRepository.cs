using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.Data.Infrastructure;
using WebShop.Model.Models;

namespace WebShop.Data.Repositories
{
    public interface IProductTagRepository : IRepository<ProductTag>
    {

    }
    public class ProductTagRepository : RepositoryBase<ProductTag>, IProductTagRepository
    {
        public ProductTagRepository(IDBFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
