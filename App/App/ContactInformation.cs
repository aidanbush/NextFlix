﻿using System;
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

        /* getters and setters */
        public String Email { get => email; set => email = value; }
        public String PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

    }
}
