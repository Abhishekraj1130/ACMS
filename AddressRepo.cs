using ACME.CommonClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.BL
{
  public class AddressRepo
    {
        public Address Retrive(int AddressId)
        {
            Address address = new Address(AddressId);

            address.streetLine1 = "abc";
            address.streetLine2 = "xyz";
            address.city = "aaa";
            address.state = "bbb";
            address.country = "ccc";
            address.postalCode = 1234;
            address.addressType = "w";

            LoginService logObj = new LoginService();

            logObj.WriteToFile(address);

            return address;
        }

        public bool Save()
        {
            Address address = new Address();
            //TO DO:
            if (address.isNew && address.hasChanges)
            {
                if (address.isValid)
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
