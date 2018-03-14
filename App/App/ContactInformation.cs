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
            Email = eAddress;
            PhoneNumber = phone;
        }

        /* getters and setters */
        public String Email { get => email; set => email = value; }
        public String PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
    }
}
