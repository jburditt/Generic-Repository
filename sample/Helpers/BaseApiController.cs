using System.Collections;
using System.Collections.Generic;
//using System.Data.Entity.Core;
using System.Linq;
using System.Web.Http;
using Sample.Models.Data;
using Sample.Models.Interfaces;
using System.Data;
using System;

namespace Sample.DAL
{
    public class BaseApiController<T> : ApiController where T : class, IIdentifier, new()
    {
        protected IRepository DataStore { get; set; }
        protected string[] Includes { get; set; }

        public BaseApiController()
        {
            //TODO: USE DEPENDENCY INJECTION FOR DECOUPLING
            //this.DataStore = new EFRepository();
        }

        // GET api/<controller>
        public virtual IEnumerable<T> Get()
        {
            return DataStore.All<T>(Includes);
        }

        // GET api/<controller>/5
        public virtual T Get(int id)
        {
            //return DataStore.Find<T>(t => t.Id == id, Includes);
            throw new NotImplementedException();
        }

        // POST api/<controller>
        public virtual void Post([FromBody]T value)
        {
            try
            {
                DataStore.Update<T>(value);
            }
            catch (OptimisticConcurrencyException ex)
            {
                throw ex;
            }
        }

        // PUT api/<controller>
        public virtual void Put([FromBody]T value)
        {
            DataStore.Create<T>(value);
        }

        // DELETE api/<controller>/5
        public virtual void Delete(int id)
        {
            DataStore.Delete<T>(t => t.Id == id);
        }

        public virtual void Delete([FromBody]T value)
        {
            Delete(value.Id);
        }

        protected IEnumerable GetModelErrors()
        {
            return this.ModelState.SelectMany(x => x.Value.Errors.Select(error => error.ErrorMessage));
        }
    }
}