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
            if(postal == null)
            {
                postal = "";
            }

            if (IsPostalCodeValid(postal))
            {
                postalCode = ReplaceWhiteSpaceFromPostal(postal);
            }
            else
            {
                Console.WriteLine("Blank Post");
                if (postal == "")
                {
                    
                    postal = "";
                    return;
                }
                

                throw new PostalCodeException();
            }
        }
        private String ReplaceWhiteSpaceFromPostal(String code)
        {
            if (code == "")
            {
                return code;
            }
            return code.Replace(" ", "");
        }
        private bool IsPostalCodeValid(String postal)
        {
            if(postal == "")
            {
                return true;
            }
            if (postal.Length != 6 && postal.Length != 7)
            {
                return false;
            }
            String code = ReplaceWhiteSpaceFromPostal(postal);

            //check if index 0, 2, 4 are numbers, if so, throw exception
            for (int i = 0; i < code.Length; i += 2)
            {
                if(Char.IsDigit(code[i]) == true)
                {
                    return false;
                }
            }
            //Check if index 1, 3, 5 are letters, if so, throw exception
            for(int i = 1; i <code.Length; i += 2)
            {
                if (Char.IsDigit(code[i]) == false)
                {
                    return false;
                }
            }
            return true;
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
