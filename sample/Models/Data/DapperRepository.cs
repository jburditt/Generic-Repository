using System;
using System.Linq;
using System.Linq.Expressions;
using Sample.DAL;
using Sample.Models.Interfaces;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using MicroOrm.Pocos.SqlGenerator;

namespace Sample.Models.Data
{
    /* References
     * https://github.com/Yoinbol/Dapper.DataRepositories
     * http://www.nopcommerce.com/boards/t/35311/repository-for-dappernet.aspx
     */

    /// <summary>
    /// Repository provider for Dapper
    /// See base class for method comments
    /// </summary>
    public class DapperRepository //: IRepository
    {
        private IDbConnection dbContext;

        public DapperRepository()
        {
            this.dbContext = new SqlConnection(@"data source=(LocalDB)\v11.0;attachdbfilename=|DataDirectory|\SampleDatabase.mdf;integrated security=SSPI;connect timeout=30;MultipleActiveResultSets=True;");
        }

        public IQueryable<T> All<T>(string[] includes = null) where T : class, new()
        {
            var SqlGenerator = new SqlGenerator<T>();
            var sql = SqlGenerator.GetSelectAll();
            return dbContext.Query<T>(sql).AsQueryable();
        }

        public T Get<T>(Expression<Func<T, bool>> expression, string[] includes = null) where T : class
        {
            throw new NotImplementedException();
        }

        //TODO: Revisit ApiController Get Includes and consider removing this
        //TODO: Implement parameter includes
        public virtual T Find<T>(Expression<Func<T, bool>> predicate, string[] includes = null) where T : class, new()
        {
            throw new NotImplementedException();
        }

        //TODO: Implement parameter includes
        public virtual T Find<T>(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties) where T : class, new()
        {
            throw new NotImplementedException();
        }

        //TODO: This is specific to Dapper, merge this function with the above that works with EF
        public virtual T Find<T>(object predicate) where T : class, new()
        {
            var SqlGenerator = new SqlGenerator<T>();
            var sql = SqlGenerator.GetSelect(predicate);
            return dbContext.Query<T>(sql, predicate).FirstOrDefault();
        }

        public virtual IQueryable<T> Filter<T>(Expression<Func<T, bool>> predicate, string[] includes = null) where T : class
        {
            throw new NotImplementedException();
        }

        public virtual IQueryable<T> FilterSort<T>(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "") where T : class
        {
            throw new NotImplementedException();
        }

        public virtual IQueryable<T> FilterSort<T>(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, params Expression<Func<T, object>>[] includeProperties) where T : class
        {
            throw new NotImplementedException();
        }

        public virtual IQueryable<T> Filter<T>(Expression<Func<T, bool>> predicate, out int total, int index = 0, int size = 50, string[] includes = null) where T : class
        {
            throw new NotImplementedException();
        }

        public virtual int Count<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            throw new NotImplementedException();
        }

        public virtual T Create<T>(T TObject) where T : class, new()
        {
            var SqlGenerator = new SqlGenerator<T>();
            bool added = false;
            var sql = SqlGenerator.GetInsert();

            if (SqlGenerator.IsIdentity)
            {
                var newId = dbContext.Query<decimal>(sql, TObject).Single();
                added = newId > 0;

                if (added)
                {
                    var newParsedId = Convert.ChangeType(newId, SqlGenerator.IdentityProperty.PropertyInfo.PropertyType);
                    SqlGenerator.IdentityProperty.PropertyInfo.SetValue(TObject, newParsedId);
                }
            }
            else
            {
                added = dbContext.Execute(sql, TObject) > 0;
            }

            return TObject;
        }

        public virtual int Delete<T>(T TObject) where T : class
        {
            throw new NotImplementedException();
        }

        public virtual int Update<T>(T TObject) where T : class, new()
        {
            throw new NotImplementedException();
        }

        public virtual T Update<T>(int id, params Func<T, object>[] properties) where T : class, IIdentifier, new()
        {
            throw new NotImplementedException();
        }

        public virtual T Update<T>(Expression<Func<T, bool>> predicate, params Func<T, object>[] properties) where T : class, new()
        {
            throw new NotImplementedException();
        }

        public virtual int Delete<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            throw new NotImplementedException();
        }

        public virtual int Delete<T>(object id) where T : class, new()
        {
            var SqlGenerator = new SqlGenerator<T>();
            var sql = SqlGenerator.GetDelete();
            return dbContext.Execute(sql, new { Id = id });
        }

        public bool Contains<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            throw new NotImplementedException();
        }

        public virtual IQueryable<T> SelectQuery<T>(string query, params object[] parameters) where T : class
        {
            return (IQueryable<T>)dbContext.Query<T>(query, parameters);
        }

        public virtual void ExecuteCommand(String procedureCommand, params SqlParameter[] sqlParams)
        {
            using (var transaction = dbContext.BeginTransaction())
            {
                dbContext.Execute(procedureCommand, sqlParams, transaction);
            }
        }
    }
}