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
            suiteNumber = suite;
            streetNumber = street;
            houseNumber = house;
            city = town;
            province = prov;
            postalCode = CleanPostalCode(postal);
            if(postalCode == null)
            {
                throw new PostalCodeException();
            }
        }
        private String CleanPostalCode(String postal)
        {
            String code;

            Console.WriteLine(postal.Length);
            if (postal == "")
            {
                return postal; 
            }
            if (postal.Length != 6 && postal.Length != 7)
            {
                
                Console.WriteLine("WRONGE SIZE: " + postal.Length);
                return null;
            }
            code = postal.Replace(" ", "");
            //check if index 0, 2, 4 are numbers, if so, throw exception
            for (int i = 0; i < code.Length; i += 2)
            {
                if(Char.IsDigit(code[i]) == true)
                {
                    return null;
                }
            }
            //Check if index 1, 3, 5 are letters, if so, throw exception
            for(int i = 1; i <code.Length; i += 2)
            {
                if (Char.IsDigit(code[i]) == false)
                {
                    return null;
                }
            }
            return code;
        }


        /* getters and setters */
        public string SuiteNumber { get => suiteNumber; set => suiteNumber = value; }
        public string StreetNumber { get => streetNumber; set => streetNumber = value; }
        public string HouseNumber { get => houseNumber; set => houseNumber = value; }
        public string City { get => city; set => city = value; }
        public string Province { get => province; set => province = value; }
        public string PostalCode { get => postalCode; set => postalCode = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
