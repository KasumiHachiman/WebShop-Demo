using WebShop.Data.Interface;
using WebShop.Model.Models;

namespace WebShop.Data.EntityFramworkRepository
{
    public class VisitorStatisticRepository : GenericRepository<VisitorStatistic>, IVisitorStatisticRepository
    {
        public VisitorStatisticRepository(IWebShopDbContextFactory dbFactory) : base(dbFactory)
        {
        }
    }
}