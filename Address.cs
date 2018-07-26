using ACME.CommonClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.BL
{
  public  class Address : EntityBaseClass,ILoggable
    {
        public Address()
        {

        }
        public Address(int AddressId)
        {
            addressId = AddressId;
        }

        public string streetLine1 { get; set; }
        public string streetLine2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int? postalCode { get; set; }

        public string country { get; set; }
        public int addressId { get; private set; }

        public string addressType { get; set; }

        public override bool Validate()
        {

            return string.IsNullOrEmpty(streetLine1) &&
                   string.IsNullOrEmpty(streetLine2) &&
                   string.IsNullOrEmpty(city) &&
                   string.IsNullOrEmpty(state) &&
                   string.IsNullOrEmpty(country) &&
                   string.IsNullOrEmpty(addressType) &&
                   postalCode.HasValue;
        }

        public string Log()
        {

            return streetLine1 + "," + streetLine2 + "," + city+","+state+","+postalCode;
        }
    }
}
