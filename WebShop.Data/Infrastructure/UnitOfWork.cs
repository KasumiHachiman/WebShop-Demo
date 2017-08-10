using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Data.Infrastructure
{
    public class UnitOfWork : Disposable, IUnitOfWork
    {
        private readonly IDBFactory _dbFactory;
        private WebShopDbContext _dbContext;
        public UnitOfWork(IDBFactory dbFactory)
        {
            this._dbFactory = dbFactory;
        }
        public WebShopDbContext DbContext
        {
            get
            {
                // if null then init
                return _dbContext ?? (_dbContext = _dbFactory.Init());
            }
        }
         
        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}
