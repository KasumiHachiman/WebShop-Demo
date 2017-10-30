using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.Data.Interface;

namespace WebShop.Data.EntityFramworkRepository
{
    public class WebShopDbContextFactory : Disposable, IWebShopDbContextFactory
    {
        private WebShopDbContext _dbContext;
        public WebShopDbContext Init()
        {
            return _dbContext ?? (_dbContext = new WebShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (_dbContext != null)
                _dbContext.Dispose();
        }
    }
}
