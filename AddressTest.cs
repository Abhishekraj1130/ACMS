using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACME.BL;

namespace ACME.BLTest
{
    [TestClass]
    public class AddressTest
    {
        Address address = new Address();

        AddressRepo addObj = new AddressRepo();
        [TestMethod]
        public void RetriveByAddressIdTest()
        {
            //Expect
            address.streetLine1 = "abc";
            address.streetLine2 = "xyz";
            address.city = "aaa";
            address.state = "bbb";
            address.country = "ccc";
            address.postalCode = 1234;
            address.addressType = "w";

            //Actual
            Address actual = addObj.Retrive(10);

            //Assert
            Assert.AreEqual(address.streetLine1,actual.streetLine1);
            Assert.AreEqual(address.streetLine2, actual.streetLine2);
            Assert.AreEqual(address.city, actual.city);
            Assert.AreEqual(address.state, actual.state);
            Assert.AreEqual(address.country, actual.country);
            Assert.AreEqual(address.postalCode, actual.postalCode);
            Assert.AreEqual(address.addressType, actual.addressType);
        }
    }
}
