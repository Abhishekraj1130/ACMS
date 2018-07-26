using ACME.CommonClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.BL
{
   public class Products:EntityBaseClass,ILoggable
    {
        public Products()
        {

        }
        public Products(int Productid)
        {
            productId = Productid;
        }

        public string description { get; set; }

        public decimal? currentPrice { get; set; }

        public string productName { get; set; }

        public int productId { get; private set; }

        public override bool Validate()
        {

            return currentPrice.HasValue && string.IsNullOrEmpty(productName);
        }

        public string Log()
        {

            return productId + "," + description + "," + currentPrice+","+productName;
        }
    }
}
