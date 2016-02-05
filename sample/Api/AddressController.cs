using System;
using System.Web.Http;
using Sample.DAL;
using Sample.Models.Data;

namespace Sample.Api
{
    public class AddressController : BaseApiController<Address>
    {
        //private static readonly IRepository Repository = new EFRepository();

        /*[ActionName("getaddressfrompostalcode")]
        public Address GetAddressFromPostalCode(string name)
        {
            var postalCode = Repository.Find<PostalCode>(q => q.PostalCode == name.ToUpper());
            if (postalCode == null) return null;
            return new Address
            {
                City = postalCode.City,
                province_id = postalCode.province_id ?? 0,
                country_id = postalCode.country_id
            };
        }*/
    }
}