using Sample.DAL;
using Sample.Models.Data.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Sample.Models.Data
{
    public class DapperUnitOfWork : IDisposable
    {
        private readonly IDbConnection dbContext;
        private IRepository Repository;

        public DapperUnitOfWork() : this(
            new SqlConnection(@"data source=(LocalDB)\v11.0;attachdbfilename=|DataDirectory|\SampleDatabase.mdf;integrated security=SSPI;connect timeout=30;MultipleActiveResultSets=True;")) 
        {
        }

        public DapperUnitOfWork(IDbConnection dbContext)
        {
            this.dbContext = dbContext;
            if (dbContext.State != ConnectionState.Open && dbContext.State != ConnectionState.Connecting)
                dbContext.Open();
        }

        public virtual void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            if (dbContext != null && dbContext.State != ConnectionState.Closed)
                dbContext.Close();
        }
    }
}