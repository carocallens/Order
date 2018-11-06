using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Domain.Users
{
    public class Address
    {
        public string Street { get; private set; }
        public string StreetNumber { get; private set; }
        public int PostalCode { get; private set; }
        public string City { get; private set; }

        public Address(string street, string streetNumber, int postalCode, string city)
        {
            Street = street;
            StreetNumber = streetNumber;
            PostalCode = postalCode;
            City = city;
        }
    }
}
