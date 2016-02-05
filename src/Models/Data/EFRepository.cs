using System;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using WBS.DAL;
using WBS.Models.Interfaces;

namespace WBS.Models.Data
{
    /// <summary>
    /// Repository provider for Entity Framework
    /// See base class for method comments
    /// </summary>
    public class EFRepository : IRepository
    {
        private readonly WBSContext dbContext;

        public EFRepository()
        {
            dbContext = new WBSContext();
            //SERIALIZE WILL FAIL WITH PROXIED ENTITIES
            dbContext.Configuration.ProxyCreationEnabled = false;
            //ENABLING COULD CAUSE ENDLESS LOOPS AND PERFORMANCE PROBLEMS
            dbContext.Configuration.LazyLoadingEnabled = false;
            // Disable tracking for performance increase and tracking related issues
            // This is needed for Update function with lambda.invoke which changes the object, SaveChanges saves the changes tracked by EF
            dbContext.Configuration.AutoDetectChangesEnabled = true;
        }

        public IQueryable<T> All<T>(string[] includes = null) where T : class
        {
            //HANDLE INCLUDES FOR ASSOCIATED OBJECTS IF APPLICABLE
            if (includes != null && includes.Any())
            {
                var query = dbContext.Set<T>().Include(includes.First());
                query = includes.Skip(1).Aggregate(query, (current, include) => current.Include(include));
                return query.AsQueryable();
            }
            return dbContext.Set<T>().AsQueryable();
        }

        public T Get<T>(Expression<Func<T, bool>> expression, string[] includes = null) where T : class
        {
            return All<T>(includes).FirstOrDefault(expression);
        }

        //TODO: Revisit ApiController Get Includes and consider removing this
        public virtual T Find<T>(Expression<Func<T, bool>> predicate, string[] includes = null) where T : class
        {
            //HANDLE INCLUDES FOR ASSOCIATED OBJECTS IF APPLICABLE
            if (includes != null && includes.Any())
            {
                var query = dbContext.Set<T>().Include(includes.First());
                query = includes.Skip(1).Aggregate(query, (current, include) => current.Include(include));
                return query.FirstOrDefault<T>(predicate);
            }
            return dbContext.Set<T>().FirstOrDefault<T>(predicate);
        }

        public virtual T Find<T>(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties) where T : class
        {
            IQueryable<T> query = dbContext.Set<T>();
            query = includeProperties.Aggregate(query, (current, selector) => current.Include(selector));
            return query.FirstOrDefault(predicate);
        }

        public virtual IQueryable<T> Filter<T>(Expression<Func<T, bool>> predicate, string[] includes = null) where T : class
        {
            //HANDLE INCLUDES FOR ASSOCIATED OBJECTS IF APPLICABLE
            if (includes != null && includes.Count() > 0)
            {
                var query = dbContext.Set<T>().Include(includes.First());
                foreach (var include in includes.Skip(1))
                    query = query.Include(include);
                return query.Where(predicate).AsQueryable();
            }
            return dbContext.Set<T>().Where<T>(predicate).AsQueryable<T>();
        }

        public virtual IQueryable<T> FilterSort<T>(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "") where T : class
        {
            IQueryable<T> query = dbContext.Set<T>();
            if (filter != null)
                query = query.Where(filter);
            query = includeProperties.Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries)
                .Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            return orderBy != null ? orderBy(query) : query;
        }

        public virtual IQueryable<T> FilterSort<T>(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, params Expression<Func<T, object>>[] includeProperties) where T : class
        {
            IQueryable<T> query = dbContext.Set<T>();
            if (filter != null)
                query = query.Where(filter);
            query = includeProperties.Aggregate(query, (current, selector) => current.Include(selector));
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
            //ADD LAST MODIFIED DATE IF APPLICABLE
            if (TObject is IModifiedOn)
            {
                (TObject as IModifiedOn).ModifiedOn = DateTime.Now;
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
        //TODO: Change int id to object id a KeyValues object, and use Find(object id)
        public virtual T Update<T>(int id, params Func<T, object>[] properties) where T : class, IIdentifier
        {
            //var obj = dbContext.Set<T>().Find(id)
            var obj = Find<T>(q => q.id == id);
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
            var objects = Filter(predicate);
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
            return dbContext.Set<T>().Count<T>(predicate) > 0;
        }

        public virtual IQueryable<T> SelectQuery<T>(string query, params object[] parameters) where T : class
        {
            return dbContext.Set<T>().SqlQuery(query, parameters).AsQueryable();
        }

        public virtual void ExecuteCommand(String procedureCommand, params SqlParameter[] sqlParams)
        {
            dbContext.Database.ExecuteSqlCommand(procedureCommand, sqlParams);
        }

        public virtual void SaveChanges()
        {
            dbContext.SaveChanges();
        }

        public void Dispose()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}