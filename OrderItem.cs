using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.BL
{
   public class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int OrderItemId)
        {
            orderItemId = OrderItemId;
        }

        public int quantity { get; set; }

        public decimal? purchasePrice { get; set; }

        public int productId { get; set; }

        public int orderItemId { get; private set; }

        public bool Validate()
        {

            return purchasePrice.HasValue && quantity>0;
        }

       
    }
}
