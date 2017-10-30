using WebShop.Data.Interface;
using WebShop.Model.Models;

namespace WebShop.Data.EntityFramworkRepository
{

    public class SlideRepository : GenericRepository<Slide>, ISlideRepository
    {
        public SlideRepository(IWebShopDbContextFactory dbFactory) : base(dbFactory)
        {
        }
    }
}