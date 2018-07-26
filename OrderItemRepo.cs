using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.BL
{
   public class OrderItemRepo
    {
        public OrderItem Retrive(int orderItemId)
        {
            OrderItem order = new OrderItem(orderItemId);

            order.quantity = 100;
            order.purchasePrice = 2500;
            order.productId = 10;
            return order;
        }
    }
}
