using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sample.BLL;
using Sample.Models.Data.DTO;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace UnitTest
{
    [TestClass]
    public class UnitTests
    {
        [TestInitialize]
        public void TestInitialize()
        {
            //@"C:\Users\Jebb\Documents\GitHub\Generic-Repository\sample\App_Data"
            var path = (string)AppDomain.CurrentDomain.BaseDirectory;
            var dir = Directory.GetParent(path).Parent;
            AppDomain.CurrentDomain.SetData("DataDirectory", dir.Parent.FullName + @"\sample\App_Data");
        }

        [TestMethod]
        public void TestAddAddress()
        {
            //using (var uow = new DapperUnitOfWork())
            //{
                var temp = new AddressDTO { AddressLine1 = "117 27th Street E", AddressLine2 = "#3", City = "North Vancouver", PostalCode = "V7N1B3" };
                var id = AddressBLL.Insert(temp).Id;
                var address = AddressBLL.Find(p => p.Id == id);
                Assert.AreEqual("117 27th Street E", address.AddressLine1);
                AddressBLL.Delete(id);
            //}
        }

        [TestMethod]
        public void TestGetAddress()
        {
            var addresses = AddressBLL.All();
            var count = 0;
            foreach (var address in addresses)
            {
                count++;
            }
            Assert.IsTrue(count > 0);
        }

        [TestMethod]
        public void Test_ComplexQuery()
        {
            //PopulateData();
            var user = UserBLL.Find(p => p.FirstName == "Jebb", i => i.Address);
            Assert.AreEqual(user.FirstName, "Jebb");

            var users = UserBLL.UsersInCityDepartment(p => p.FirstName == "Jebb", "North Vancouver", 0);
            Assert.IsTrue(users.Count() > 0);
        }

        // TODO Replace LocalDB with Mocked Database

        private void DeleteAll()
        {
            //AddressBLL.DeleteAll();
        }

        private void PopulateData()
        {
            List<AddressDTO> addresses = new List<AddressDTO>();
            addresses.Add(new AddressDTO { AddressLine1 = "117 27th Street E", AddressLine2 = "#3", City = "North Vancouver", PostalCode = "V7N1B3" });
            addresses.Add(new AddressDTO { AddressLine1 = "125 21th Avenue E", AddressLine2 = "", City = "Burnaby", PostalCode = "V0N1C3" });
            addresses.Add(new AddressDTO { AddressLine1 = "11 27th Street W", AddressLine2 = "", City = "Vancouver", PostalCode = "V1N1C3" });
            addresses = AddressBLL.Insert(addresses).ToList();

            List<UserDTO> users = new List<UserDTO>();
            users.Add(new UserDTO { FirstName = "Jebb", LastName = "Burditt", AddressId = addresses[0].Id });
            users.Add(new UserDTO { FirstName = "Brian", LastName = "Denomey", AddressId = addresses[1].Id });
            users.Add(new UserDTO { FirstName = "Ryan", LastName = "Crawford", AddressId = addresses[2].Id });
            users.Add(new UserDTO { FirstName = "Anabel", LastName = "Chiurang" });
            users = UserBLL.Insert(users).ToList();

            List<DepartmentDTO> departments = new List<DepartmentDTO>();
            departments.Add(new DepartmentDTO { Name = "Finance" });
            departments.Add(new DepartmentDTO { Name = "IT" });
            departments.Add(new DepartmentDTO { Name = "Marketing" });
            departments.Add(new DepartmentDTO { Name = "Sales" });
            departments.Add(new DepartmentDTO { Name = "Human Resources" });
            departments = DepartmentBLL.Insert(departments).ToList();

            List<UserDepartmentDTO> userDepartments = new List<UserDepartmentDTO>();
            userDepartments.Add(new UserDepartmentDTO { UserId = users[0].Id, DepartmentId = departments[0].Id });
            userDepartments.Add(new UserDepartmentDTO { UserId = users[1].Id, DepartmentId = departments[0].Id });
            userDepartments.Add(new UserDepartmentDTO { UserId = users[1].Id, DepartmentId = departments[1].Id });
            userDepartments.Add(new UserDepartmentDTO { UserId = users[2].Id, DepartmentId = departments[2].Id });
            userDepartments.Add(new UserDepartmentDTO { UserId = users[3].Id, DepartmentId = departments[3].Id });
            userDepartments = UserDepartmentBLL.Insert(userDepartments).ToList();
        }
    }
}