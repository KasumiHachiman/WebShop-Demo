using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Data.Infrastructure
{
    // thuc thi cac class from iRepository
    public abstract class RepositoryBase<T> : IRepository<T> where T : class
    {
        private WebShopDbContext _dbContext;
        //exec query on dbset(dataset) with table dbcontext
        private readonly IDbSet<T> _dbSet;
        public RepositoryBase(IDBFactory dbFactory)
        {
            DBFactory = dbFactory;
            _dbSet = DBContext.Set<T>();
        }
        //only inheritance to see it
        protected IDBFactory DBFactory
        {
            get;
            private set;
        }
        protected WebShopDbContext DBContext
        {
            get { return _dbContext ?? (_dbContext = DBFactory.Init()); }
        }
        //allow inheritance
        public virtual T Add(T entity)
        {
            return _dbSet.Add(entity);
        }

        public virtual int Count(Expression<Func<T, bool>> where)
        {
            return _dbSet.Count(where);
        }
        public virtual T Delete(T entity)
        {
            return _dbSet.Remove(entity);
        }
        public virtual T Delete(string id)
        {
            var entity = _dbSet.Find(id);
            return _dbSet.Remove(entity);
        }

        public virtual void DeleteMulti(Expression<Func<T, bool>> where)
        {
            //wher list with where after delete all(source is T ^^)
            IEnumerable<T> objects = _dbSet.Where<T>(where).AsEnumerable();
            foreach(T obj in objects)
            {
                _dbSet.Remove(obj);
            }
        }

        public IEnumerable<T> GetAll(string[] includes = null)
        {
            //get all with includes
            if(includes!=null && includes.Count()>0)
            {
                var query = _dbContext.Set<T>().Include(includes.First());
                foreach(var include in includes.Skip(1))
                {
                    query = query.Include(include);
                }
                return query.AsEnumerable();
            }
            return _dbContext.Set<T>().AsQueryable();
        }

        public IEnumerable<T> GetMulti(Expression<Func<T, bool>> expression, string[] includes = null)
        {
           if(includes!=null && includes.Count()>0)
            {
                var query = _dbContext.Set<T>().Include(includes.First());
                foreach(var include in includes.Skip(1))
                {
                    query = query.Include(include);

                }
                return query.Where<T>(expression).AsQueryable();
            }
            return _dbContext.Set<T>().Where(expression).AsQueryable();
        }

        public IEnumerable<T> GetMultiPagging(Expression<Func<T, bool>> filter, out int total, int index = 0, int size = 50, string[] includes = null)
        {
            int skipcount = index * size;
            IQueryable<T> _resetSet;
            if (includes != null && includes.Count() > 0)
            {
                var query = _dbContext.Set<T>().Include(includes.First());
                foreach (var include in includes.Skip(1))
                    query = query.Include(include);
                _resetSet = filter != null ? query.Where<T>(filter).AsQueryable() : query.AsQueryable();
            }
            else
            {
                _resetSet = filter != null ? _dbContext.Set<T>().Where(filter).AsQueryable() : _dbContext.Set<T>().AsQueryable();
            }
            total = _resetSet.Count();
            return _resetSet.AsQueryable();
        }

        public T GetSingleByCondition(Expression<Func<T, bool>> expression, string[] includes = null)
        {
            if (includes != null && includes.Count() > 0)
            {
                var query = _dbContext.Set<T>().Include(includes.First());
                foreach (var include in includes.Skip(1))
                {
                    query = query.Include(include);

                }
                return query.FirstOrDefault(expression);
            }
            return _dbContext.Set<T>().FirstOrDefault(expression);
        }

        public T GetSingleById(string id)
        {
            return _dbSet.Find(id);
        }

        public virtual void Update(T entity)
        {
            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }
    }
}
