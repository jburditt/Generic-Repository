using System;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using Sample.DAL;
using Sample.Models.Interfaces;

namespace Sample.Models.Data
{
    /// <summary>
    /// Repository provider for Entity Framework
    /// See IRepository for method descriptions
    /// </summary>
    public class EFRepository : IDisposable//IRepository
    {
        internal readonly Entities dbContext;

        public EFRepository()
        {
            dbContext = new Entities();
            //SERIALIZE WILL FAIL WITH PROXIED ENTITIES
            dbContext.Configuration.ProxyCreationEnabled = false;
            //ENABLING COULD CAUSE ENDLESS LOOPS AND PERFORMANCE PROBLEMS
            dbContext.Configuration.LazyLoadingEnabled = false;
            // Disable tracking for performance increase and tracking related issues
            dbContext.Configuration.AutoDetectChangesEnabled = true;
        }

        public IQueryable<T> All<T>(params Expression<Func<T, object>>[] includes) where T : class
        {
            IQueryable<T> query = dbContext.Set<T>();
            query = includes.Aggregate(query, (current, selector) => current.Include(selector));
            return query.AsQueryable();
        }

        public T Get<T>(Expression<Func<T, bool>> expression, Expression<Func<T, object>>[] includes = null) where T : class
        {
            return All(includes).FirstOrDefault(expression);
        }

        public T GetById<T>(object id) where T : class
        {
            return dbContext.Set<T>().Find(id);
        }

        public virtual T Find<T>(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes) where T : class
        {
            IQueryable<T> query = dbContext.Set<T>();
            query = includes.Aggregate(query, (current, selector) => current.Include(selector));
            return query.FirstOrDefault(predicate);
        }

        public virtual IQueryable<T> FilterSort<T>(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, params Expression<Func<T, object>>[] includes) where T : class
        {
            IQueryable<T> query = dbContext.Set<T>();
            if (filter != null)
                query = query.Where(filter);
            query = includes.Aggregate(query, (current, selector) => current.Include(selector));
            return orderBy != null ? orderBy(query) : query;
        }

        public virtual IQueryable<T> Filter<T>(Expression<Func<T, bool>> predicate, out int total, int index = 0, int size = 50, string[] includes = null) where T : class
        {
            int skipCount = index*size;
            IQueryable<T> _resetSet;
            //HANDLE INCLUDES FOR ASSOCIATED OBJECTS IF APPLICABLE
            if (includes != null && includes.Any())
            {
                var query = dbContext.Set<T>().Include(includes.First());
                query = includes.Skip(1).Aggregate(query, (current, include) => current.Include(include));
                _resetSet = predicate != null ? query.Where<T>(predicate).AsQueryable() : query.AsQueryable();
            }
            else
            {
                _resetSet = predicate != null
                    ? dbContext.Set<T>().Where<T>(predicate).AsQueryable()
                    : dbContext.Set<T>().AsQueryable();
            }
            _resetSet = skipCount == 0 ? _resetSet.Take(size) : _resetSet.Skip(skipCount).Take(size);
            total = _resetSet.Count();
            return _resetSet.AsQueryable();
        }

        public virtual int Count<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            return dbContext.Set<T>().Count(predicate);
        }

        public virtual T Create<T>(T TObject) where T : class
        {
            //ADD CREATE DATE IF APPLICABLE
            if (TObject is ICreatedOn)
            {
                (TObject as ICreatedOn).CreatedOn = DateTime.Now;
            }
            var newEntry = dbContext.Set<T>().Add(TObject);
            dbContext.SaveChanges();
            return newEntry;
        }

        public virtual int Delete<T>(T TObject) where T : class
        {
            dbContext.Set<T>().Remove(TObject);
            return dbContext.SaveChanges();
        }

        // Update all table columns
        public virtual int Update<T>(T TObject) where T : class
        {
            //ADD LAST MODIFIED DATE IF APPLICABLE
            if (TObject is IModifiedOn)
                (TObject as IModifiedOn).ModifiedOn = DateTime.Now;

            var entry = dbContext.Entry(TObject);
            dbContext.Set<T>().Attach(TObject);
            entry.State = EntityState.Modified;
            return dbContext.SaveChanges();
        }

        // Update table columns provided
        public virtual T Update<T>(object id, params Func<T, object>[] properties) where T : class
        {
            var obj = dbContext.Set<T>().Find(id);
            dbContext.Set<T>().Attach(obj);
            foreach (var lambda in properties)
                lambda.Invoke(obj);
            dbContext.SaveChanges();
            return obj;
        }

        // Update table columns provided
        public virtual T Update<T>(Expression<Func<T, bool>> predicate, params Func<T, object>[] properties) where T : class
        {
            var obj = Find(predicate);
            dbContext.Set<T>().Attach(obj);
            foreach (var lambda in properties)
                lambda.Invoke(obj);
            dbContext.SaveChanges();
            return obj;
        }

        public virtual int Delete<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            var objects = FilterSort(predicate);
            foreach (var obj in objects)
                dbContext.Set<T>().Remove(obj);
            return dbContext.SaveChanges();
        }

        public virtual int Delete<T>(object id) where T : class
        {
            var entityToDelete = dbContext.Set<T>().Find(id);
            return Delete(entityToDelete);
        }

        public bool Contains<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            return dbContext.Set<T>().Count(predicate) > 0;
        }

        public virtual IQueryable<T> SelectQuery<T>(string query, params object[] parameters) where T : class
        {
            return dbContext.Set<T>().SqlQuery(query, parameters).AsQueryable();
        }

        public virtual void ExecuteCommand(string procedureCommand, params SqlParameter[] sqlParams)
        {
            dbContext.Database.ExecuteSqlCommand(procedureCommand, sqlParams);
        }

        public virtual void SaveChanges()
        {
            dbContext.SaveChanges();
        }

        public void Dispose()
        {
            dbContext?.Dispose();
        }
    }
}
