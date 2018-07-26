using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACME.BL;

namespace ACME.BLTest
{
    [TestClass]
    public class OrderItemTest
    {
        OrderItem order = new OrderItem();

        OrderItemRepo orderObj = new OrderItemRepo();

        [TestMethod]

        public void RetriveByOrderItemIdTest()
        {
            //Expect
            order.quantity = 100;
            order.purchasePrice = 2500;
            order.productId = 10;

            //Actual

            OrderItem actual = orderObj.Retrive(10);

            //Assert

            Assert.AreEqual(order.quantity,actual.quantity);
            Assert.AreEqual(order.purchasePrice,actual.purchasePrice);
            Assert.AreEqual(order.productId,actual.productId);
        }
    }
}
