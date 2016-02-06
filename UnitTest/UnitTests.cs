using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sample.BLL;
using Sample.Models.Data.DTO;
using System.IO;
using System.Collections.Generic;

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
                var id = AddressBLL.Insert(new AddressDTO { AddressLine1 = "117 27th Street E", AddressLine2 = "#3", City = "North Vancouver", PostalCode = "V7N1B3" }).Id;
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
            DeleteAll();
        }

        // TODO Replace LocalDB with Mocked Database

        private void DeleteAll()
        {
            //AddressBLL.DeleteAll();
        }

        private void PopulateData()
        {
            List<AddressDTO> Addresses = new List<AddressDTO>();
            Addresses.Add(new AddressDTO { AddressLine1 = "117 27th Street E", AddressLine2 = "#3", City = "North Vancouver", PostalCode = "V7N1B3" });
            Addresses.Add(new AddressDTO { AddressLine1 = "125 21th Avenue E", AddressLine2 = "", City = "Burnaby", PostalCode = "V0N1C3" });
            Addresses.Add(new AddressDTO { AddressLine1 = "11 27th Street W", AddressLine2 = "", City = "Vancouver", PostalCode = "V1N1C3" });
            AddressBLL.Insert(Addresses);

            //List<UserDTO> Users = new List<UserDTO>();

        }
    }
}