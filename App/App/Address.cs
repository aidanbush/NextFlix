using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Address
    {
        private String suiteNumber;
        private String streetNumber;
        private String houseNumber;
        private String city;
        private String province;
        private String postalCode;

        public Address(String suite, String street, String house,String town, String prov, String postal)
        {
            suiteNumber = suite;
            streetNumber = street;
            houseNumber = house;
            city = town;
            province = prov;
            postalCode = postal;
        }

        public String GetSuiteNumber()
        {
            return suiteNumber;
        }
        public String GetStreetNumber()
        {
            return streetNumber;
        }
        public String GetHouseNumber()
        {
            return houseNumber;
        }
        public String GetCity()
        {
            return city;
        }
        public String GetProvince()
        {
            return province;
        }
        public String GetPostal()
        {
            return postalCode;
        }

    }
}
