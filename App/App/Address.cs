using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class Address
    {
        private String suiteNumber;
        private String streetNumber;
        private String houseNumber;
        private String city;
        private String province;
        private String postalCode;

        public Address(String suite, String street, String house,String town, String prov, String postal)
        {
            SuiteNumber = suite;
            StreetNumber = street;
            HouseNumber = house;
            City = town;
            Province = prov;
            PostalCode = postal;
        }

        /* getters and setters */
        public string SuiteNumber { get => suiteNumber; set => suiteNumber = value; }
        public string StreetNumber { get => streetNumber; set => streetNumber = value; }
        public string HouseNumber { get => houseNumber; set => houseNumber = value; }
        public string City { get => city; set => city = value; }
        public string Province { get => province; set => province = value; }
        public string PostalCode { get => postalCode; set => postalCode = value; }
    }
}
