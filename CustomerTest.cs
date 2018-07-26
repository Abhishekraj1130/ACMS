using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACME.BL;
using System.Collections.Generic;

namespace ACME.BLTest
{
    [TestClass]
    public class CustomerTest 
    {
        CustomerRepo customer = new CustomerRepo();
        Customer custObj = new Customer();
        [TestMethod]
        public void fullnameTest()
        {

            custObj.firstname = "John";
            custObj.lastname = "Manu";

            //Expect
            string expected = "Manu John";

            //Actual
            string actaul = custObj.fullname;

            //Assert
            Assert.AreEqual(expected, actaul);
        }

        [TestMethod]
        public void firstnameTest()
        {
            custObj.lastname = "Manu";

            //Expect
            string expected = "Manu ";

            //Actual
            string actaul = custObj.fullname;

            //Assert
            Assert.AreEqual(expected, actaul);
        }

        [TestMethod]
        public void lastnameTest()
        {
            custObj.firstname = "Ann";

            //Expect
            string expected = " Ann";

            //Actual
            string actaul = custObj.fullname;

            //Assert
            Assert.AreEqual(expected, actaul);
        }

       [TestMethod]

       public void RetriveByCustomerIdTest()
        {
            

            //Expect
            custObj.firstname = "Ann";
            custObj.lastname = "Mariya";
            custObj.EmailId = "abc@abc";

            //Actual
            
            Customer actual = customer.Retrive(10);

            //Assert
            Assert.AreEqual(custObj.firstname, actual.firstname);
            Assert.AreEqual(custObj.lastname, actual.lastname);
            Assert.AreEqual(custObj.EmailId, actual.EmailId);          

        }

        [TestMethod]

        public void RetriveCustomer()
        {
            List<Customer> expected = new List<Customer>();

            Customer cust = new Customer(10);
            
            //Expect           
            cust.firstname = "Anu";
            cust.lastname = "Jose";
            cust.EmailId = "xyz@zyz";

            expected.Add(cust);

            cust = new Customer(20);
        
            cust.firstname = "Manu";
            cust.lastname = "k";
            cust.EmailId = "mno@mno";

            expected.Add(cust);

            //Actual
            List<Customer> actual = customer.Retrive();

            //Assert

            expected[0].Equals(actual[0]);
            expected[1].Equals(actual[1]);
            //CollectionAssert.AreEquivalent(expected[0], actual[0]);          
        }



    }
}
