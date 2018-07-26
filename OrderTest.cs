using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACME.BL;

namespace ACME.BLTest
{
    [TestClass]
    public class OrderTest
    {
        Order order = new Order();

        OrderRepo orderObj = new OrderRepo();
        [TestMethod]
        public void RetriveByOrderIdTest()
        {       

            //Expect
            order.orderDate = new DateTime(2017, 04, 18);
            order.customerId = 10;

            //Actual
            Order actual = orderObj.Retrive(10);

            //Assert
            Assert.AreEqual(order.orderDate,actual.orderDate);
            Assert.AreEqual(order.customerId, actual.customerId);
        }
    }
}
