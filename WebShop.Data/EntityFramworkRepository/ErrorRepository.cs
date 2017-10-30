using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.Data.Interface;
using WebShop.Model.Models;

namespace WebShop.Data.EntityFramworkRepository
{
    public class ErrorRepository : GenericRepository<Error>,IErrorRepository
    {
        public ErrorRepository(IWebShopDbContextFactory dbFactory)
            :base(dbFactory)
        {

        }
    }
}
