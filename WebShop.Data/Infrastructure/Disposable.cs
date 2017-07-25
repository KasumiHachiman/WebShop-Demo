using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Data.Infrastructure
{
    public class Disposable : IDisposable
    {
        public bool _isDisposed;
        ~Disposable()
        {
            Dispose(false);
        }
        public void Dispose(bool disposing)
        {
            //neu chua disposed va disposing
            if (!_isDisposed && disposing)
                DisposeCore();
            _isDisposed = true;
        }
        public virtual void DisposeCore()
        {

        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
