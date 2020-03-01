using ACME.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer:EntityBase, ILoggable
    {

        public Customer()
            :this(0)
        {
            
        }

        public Customer(int customerId)
        {
            this.CustomerId = customerId;
            AddressList = new List<Address>();
        }


        public static int InstanceCount { get; set; }
        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string FirstName { get; set; }
        public string EmailAddress { get; set; }

        public int CustomerId { get; private set; }

        public List<Address> AddressList { get; set; }

        public int CustomerType { get; set; }


        public string FullName { get {

                string fullName = LastName;
                if (!String.IsNullOrWhiteSpace(FirstName))
                {
                    if (!String.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
        
        public bool Save(Customer customer)
        {
            var success = true;

            if (customer.HasChanges && customer.IsValid)
            {
                if (customer.IsNew)
                {

                }
                else
                {

                }
            }

            return success;
        }
     

        public override bool Validate()
        {
            var isValid = true;

            if(string.IsNullOrWhiteSpace(LastName) || string.IsNullOrWhiteSpace(EmailAddress))
            {
                isValid = false;
            }
                

            return isValid;
        }
        public override string ToString()
        {
            return FullName;
        }

        public string Log()
        {
            var logString = $"{this.CustomerId} : {this.FullName} Email: {this.EmailAddress} Status; {this.EntityState.ToString()}";
            return logString;
        }


    }
}
