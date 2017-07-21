using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Data.Infrastructure
{
    public interface IDBFactory : IDisposable
    {
        //thong qua factory gian tiep tao entity
        WebShopDbContext Init();

    }
}
