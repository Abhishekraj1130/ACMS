using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACME.BL;

namespace ACME.BLTest
{
    [TestClass]
    public class ProductTest
    {
        Products pro = new Products();

        ProductRepo proObj = new ProductRepo();


        [TestMethod]
        public void RetriveByProductIdTest()
        {          
            //Expect
            pro.description = "Good Quality";
            pro.currentPrice =2000;
            pro.productName = "abc";

            //Actual
            Products actual = proObj.Retrive(10);

            //Assert
            Assert.AreEqual(pro.description, actual.description);
            Assert.AreEqual(pro.currentPrice, actual.currentPrice);
            Assert.AreEqual(pro.productName, actual.productName);
        }
    }
}
