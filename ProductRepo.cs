using ACME.CommonClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.BL
{
   public class ProductRepo
    {
        public Products Retrive(int productId)
        {
            Products pro = new Products(productId);

            pro.description = "Good Quality";
            pro.currentPrice = 2000;
            pro.productName = "abc";

            LoginService logObj = new LoginService();

            logObj.WriteToFile(pro);

            return pro;
        }

        public bool Save()
        {
            Products product = new Products();
            //TO DO:
            if (product.isNew && product.hasChanges)
            {
                if (product.isValid)
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
