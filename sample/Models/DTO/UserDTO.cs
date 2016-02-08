using System;
using Sample.Models.Interfaces;
using System.Collections;

namespace Sample.Models.Data.DTO
{
    public partial class UserDTO : IDTO<UserDTO, User>
    {
        public IList Departments;
    }
}