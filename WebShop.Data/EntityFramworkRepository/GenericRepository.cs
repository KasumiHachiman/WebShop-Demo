using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.Data.Interface;

namespace WebShop.Data.EntityFramworkRepository
{
    public abstract class GenericRepository<T> : IRepository<T> where T : class
    {
        private WebShopDbContext _dbContext;
        protected readonly IWebShopDbContextFactory ContextFactory;
        protected GenericRepository(IWebShopDbContextFactory contextFactory)
        {
            ContextFactory = contextFactory;
        }
        protected IWebShopDbContextFactory DbFactory
        {
            get;
            private set;
        }
        protected WebShopDbContext DbContext
        {
            get { return _dbContext ?? (_dbContext = DbFactory.Init()); }
        }
        public virtual T Add(T entity)
        {
            return ContextFactory.Init().Set<T>().Add(entity);
        }

        public bool CheckContains(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return ContextFactory.Init().Set<T>().Count<T>(predicate) > 0;
        }

        public int Count(System.Linq.Expressions.Expression<Func<T, bool>> where)
        {
            return ContextFactory.Init().Set<T>().Count(where);
        }

        public virtual T Delete(int id)
        {
            T existsEntity = ContextFactory.Init().Set<T>().Find(id);
            return ContextFactory.Init().Set<T>().Remove(existsEntity);
        }

        public virtual T Delete(T entity)
        {
            return ContextFactory.Init().Set<T>().Remove(entity);
        }

        public void DeleteMulti(System.Linq.Expressions.Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = ContextFactory.Init().Set<T>().Where<T>(where).AsEnumerable();
            foreach(T obj in objects)
            {
                ContextFactory.Init().Set<T>().Remove(obj);
            }
        }

        public IQueryable FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = ContextFactory.Init().Set<T>().Where(predicate);
            return query;
        }

        public virtual IQueryable<T> GetAll(string[] includes = null)
        {
            //IQueryable<T> query = ContextFactory.Init().Set<T>();
            //return query;

            //HANDLE INCLUDES FOR ASSOCIATED OBJECTS IF APPLICABLE
            if (includes != null && includes.Count() > 0)
            {
                var query = ContextFactory.Init().Set<T>().Include(includes.First());
                foreach (var include in includes.Skip(1))
                    query = query.Include(include);
                return query.AsQueryable();
            }
            return ContextFactory.Init().Set<T>().AsQueryable();
        }

        public IEnumerable<T> GetMulti(System.Linq.Expressions.Expression<Func<T, bool>> predicate, string[] includes = null)
        {
            return ContextFactory.Init().Set<T>().Where(predicate).ToList();
        }

        public IQueryable<T> GetMultiPaging(System.Linq.Expressions.Expression<Func<T, bool>> filter, out int total, int index = 0, int size = 50, string[] includes = null)
        {
            int skipCount = index * size;
            IQueryable<T> _resetSet;

            if (includes != null && includes.Count() > 0)
            {
                var query = ContextFactory.Init().Set<T>().Include(includes.First());
                foreach (var include in includes.Skip(1))
                    query = query.Include(include);
                _resetSet = filter != null ? query.Where<T>(filter).AsQueryable() : query.AsQueryable();
            }
            else
            {
                _resetSet = filter != null ? ContextFactory.Init().Set<T>().Where<T>(filter).AsQueryable() : ContextFactory.Init().Set<T>().AsQueryable();
            }

            _resetSet = skipCount == 0 ? _resetSet.Take(size) : _resetSet.Skip(skipCount).Take(size);
            total = _resetSet.Count();
            return _resetSet.AsQueryable();
        }

        public T GetSingleByCondition(System.Linq.Expressions.Expression<Func<T, bool>> expression, string[] includes = null)
        {
            if (includes != null && includes.Count() > 0)
            {
                var query = ContextFactory.Init().Set<T>().Include(includes.First());
                foreach (var include in includes.Skip(1))
                    query = query.Include(include);
                return query.FirstOrDefault(expression);
            }
            return ContextFactory.Init().Set<T>().FirstOrDefault(expression);
        }

        public T GetSingleById(int id)
        {
            return ContextFactory.Init().Set<T>().Find(id);
        }

        public virtual void Save()
        {
            ContextFactory.Init().SaveChanges();
        }

        public virtual void Update(T entity)
        {
            //attack
            ContextFactory.Init().Set<T>().Attach(entity);
            var entry = ContextFactory.Init().Entry(entity);
            if (entry.State != EntityState.Added)
                entry.State = EntityState.Modified;
        }
    }
}
