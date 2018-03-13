using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            phoneNumber = phone;
        }

        public String getEmail()
        {
            return email;
        }
        public String getPhoneNumber()
        {
            return phoneNumber;
        }
    }
}
