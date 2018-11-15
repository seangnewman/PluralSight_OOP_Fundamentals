﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {

        public Customer()
        {

        }

        public Customer(int customerId)
        {
            this.CustomerId = customerId;
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
        public Customer Retrieve(int customerId)
        {
            return new Customer();
        }

        public List<Customer> RetrieveAll()
        {
            return new List<Customer>();
        }
        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if(string.IsNullOrWhiteSpace(LastName) || string.IsNullOrWhiteSpace(EmailAddress))
            {
                isValid = false;
            }
                

            return isValid;
        }


    }
}
