
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Sample.Models.Data
{

using System;
    using System.Collections.Generic;
    
public partial class Address
{

    public Address()
    {

        this.Users = new HashSet<User>();

    }


    public int Id { get; set; }

    public string AddressLine1 { get; set; }

    public string AddressLine2 { get; set; }

    public string City { get; set; }

    public string PostalCode { get; set; }



    public virtual ICollection<User> Users { get; set; }

}

}