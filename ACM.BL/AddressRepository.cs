using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);

            if(addressId == 1)
            {
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshot Row";
                address.City = "Hobbiton";
                address.State = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "144";
                address.AddressType = 1;
            }

            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Bag End",
                StreetLine2 = "Bagshot Row",
                City = "Hobbiton",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "144"

            };
            addressList.Add(address);

            Address address2 = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Green Dragon",
                City = "ByWater",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "146"

            };
            addressList.Add(address2);

            return addressList;


        }

        public bool Save(Address address)
        {
            return true;
        }

        
 
    }
}
