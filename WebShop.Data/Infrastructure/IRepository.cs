using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Data.Infrastructure
{
    //generic method for all in solution
    public interface IRepository<T> where T:class
    {
        //lop ao (abstract) nam giua busineed logic va access database 
        //toi uc cau lenh query cho cac cau lenh chung (select update....)
        T Add(T entity);
        void Update(T entity);
        T Delete(string id);
        void DeleteMulti(Expression<Func<T, bool>> where);
        T GetSingleById(string id);
        //get by func condition
        T GetSingleByCondition(Expression<Func<T, bool>> expression, string[] includes = null);
        //get list by condiction
        IEnumerable<T> GetMulti(Expression<Func<T, bool>> expression, string[] includes = null);
        //get pagging with filter
        IEnumerable<T> GetMultiPagging(Expression<Func<T, bool>> filter, out int total, int index = 0, int size = 50, string[] includes = null);
        //count T with where
        int Count(Expression<Func<T, bool>> where);
        IEnumerable<T> GetAll(string[] includes = null);

    }
}
