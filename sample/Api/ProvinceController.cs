using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Sample.DAL;
using Sample.Models.Data;

namespace Api
{
    [Obsolete("Not fully implemented", true)]
    public class ProvinceController : ApiController
    {
        private static readonly IRepository Repository = new EFRepository();

        // GET api/province/getprovinces/1
        public IEnumerable<province> GetProvinces(int id)
        {
            return Repository.FilterSort<province>(q => q.country_id == id).OrderBy(q => q.province_nm);
        }
    }
}
