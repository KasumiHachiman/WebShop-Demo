using WebShop.Data.Interface;
using WebShop.Model.Models;

namespace WebShop.Data.EntityFramworkRepository
{

    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(IWebShopDbContextFactory dbFactory) 
            : base(dbFactory)
        {
        }
    }
}