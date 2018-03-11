using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class CustomerInsertionParameters
    {
        private UserName user;
        private Address address;
        private ContactInformation info;
        public CustomerInsertionParameters(UserName UserName, Address userAddress, ContactInformation userInfo)
        {
            user = UserName;
            address = userAddress;
            info = userInfo;
        }

        public UserName GetUserName()
        {
            return user;
        }

        public Address GetAddress()
        {
            return address;
        }

        public ContactInformation GetContactInformation()
        {
            return info;
        }
    }
}
