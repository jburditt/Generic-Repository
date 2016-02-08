using Dapper;
using Sample.DAL;
using Sample.Models.Data;
using Sample.Models.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Sample.BLL
{
    public class UserBLL : BaseController<User, UserDTO>
    {
        public static IQueryable<UserDTO> UsersInCityDepartment(Expression<Func<UserDTO, bool>> predicate, string city, int departmentId)
        {
            /*using (var repo = new EFRepository())
            {
                return Map((from u in repo.dbContext.Users
                        join a in repo.dbContext.Addresses on u.AddressId equals a.Id
                        join ud in repo.dbContext.UserDepartments on u.Id equals ud.UserId
                        where a.City == city && ud.DepartmentId == departmentId
                        select u).Where(predicate));
            }*/

            using (var repo = new DapperRepository())
            {
                /*var n = repo.QueryParentChild<UserDTO, DepartmentDTO, int>(sql, u => u.Id, u => u.Departments);
                */

                var lookup = new Dictionary<int, UserDTO>();
                var n = repo.dbContext.Query<UserDTO, DepartmentDTO, UserDTO>(@"
                    SELECT u.* FROM Users
                    JOIN a Address ON u.AddressId = a.Id
                    JOIN ud UserDepartments ON u.Id = ud.UserId
                    WHERE a.City = @ AND ud.DepartmentId = @", (u, d) =>
                {
                    UserDTO user;
                    if (!lookup.TryGetValue(u.Id, out user))
                    {
                        lookup.Add(u.Id, user = u);
                    }
                    if (user.Departments == null)
                        user.Departments = new List<DepartmentDTO>();
                    user.Departments.Add(d);
                    return user;

                },
                splitOn: "Id");

                return n.AsQueryable().Where(predicate);
            }
        }
    }
}