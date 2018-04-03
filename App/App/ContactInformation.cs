using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace App
{
    public class ContactInformation
    { 
        private String email;
        private String phoneNumber;

        public ContactInformation(String eAddress, String phone)
        {

            email = eAddress;

            phoneNumber = CleanPhone(phone);
        }
        private String CleanPhone(String phone)
        {
            Console.WriteLine(phone);
            if (phone == "")
            {
                return null;
            }
            if(phone.Length != 10)
            {
                throw new PhoneNumberException();
            }
            var stripped = Regex.Replace(phone, "[^0-9]", "");
            Console.WriteLine(stripped.ToString());
            return stripped.ToString();            
        }
        public string CleanNumberForOutput()
        {
            //(xxx) xxx-xxxx
            string number = phoneNumber;
            if (number != null)
            {
                phoneNumber.Insert(0, "(");
                phoneNumber.Insert(4, ")");
                phoneNumber.Insert(5, " ");
                phoneNumber.Insert(10, "-");
            }
            else
            {
                number = "";
            }
            return number;
        }
        /* getters and setters */
        public String Email { get => email; set => email = value; }
        public String PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

    }
}
