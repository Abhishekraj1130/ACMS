using ACME.CommonClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.BL
{
 public  class Order : EntityBaseClass, ILoggable
    {

        public Order()
        {
            OrderList = new List<OrderItem>();
        }

        public Order(int orderid)
        {
            orderId = orderid;
        }

        public string shippingAddress { get; set; }
        public List<OrderItem> OrderList { get; set; }
        public int orderId { get; private set; }
        public DateTime? orderDate { get; set; }
        public int? customerId { get; set; }

        public override bool Validate()
        {

            return orderDate.HasValue && customerId.HasValue;
        }

        public string Log()
        {
            return  orderId+","+orderDate.ToString()+","+shippingAddress;
        }
    }
}
