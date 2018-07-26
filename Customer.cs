using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACME.CommonClass;

namespace ACME.BL
{
    public class Customer : EntityBaseClass,ILoggable
    {
        public Customer()
        {
            AddressList = new List<Address>();

        }

        public Customer(int customerid)
        {
            customerId = customerid;
        }
        public string firstname { get; set; }
        public string lastname { get; set; }

        public string  EmailId{ get; set; }

        public List<Address> AddressList { get; set; }

        public string fullname
        {
            get
            {
                return lastname + " " + firstname;
            }
        }
        public int customerId { get; private set; }

        public void firstnameEmpty()
        {

            string fullname;

            if (!string.IsNullOrWhiteSpace(firstname))
            {
                //if (!string.IsNullOrWhiteSpace(fullname))
                //{
                //    fullname += " ";
                //}
                fullname =lastname;
            }
        }

        public void lastnameEmpty()
        {

            string fullname = firstname;

            if (!string.IsNullOrWhiteSpace(fullname))
            {
                fullname = firstname;
            }

        }
        
        /// <summary>
        /// validate firstname,lastname,fullname,emailid
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            return string.IsNullOrEmpty(firstname) && string.IsNullOrEmpty(lastname) && string.IsNullOrEmpty(fullname) && string.IsNullOrEmpty(EmailId);
        }

        public string Log()
        {
          
            return firstname + "," + lastname + "," + EmailId;
        }

        public bool Equals(Customer other)
        {
            return (firstname == other.firstname) && (lastname == other.lastname);
        }
    }

}
