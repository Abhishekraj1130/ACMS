using ACME.CommonClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.BL
{
 public class OrderRepo
    {
        public Order Retrive(int orderId)
        {
            Order order = new Order(orderId);

            order.orderDate = new DateTime(2017, 04, 18);

            order.customerId = 10;

            LoginService logObj = new LoginService();

            logObj.WriteToFile(order);

            return order;
        }

        public bool Save()
        {
            Order order = new Order();
            //TO DO:
            if (order.isNew && order.hasChanges)
            {
                if (order.isValid)
                {
                    //save
                }
                else
                {
                    //update
                }
            }
            return true;
        }
    }
}
