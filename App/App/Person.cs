using System;

namespace App
{
    public class Person
    {
        private int cid;
        private UserName name;
        private Address address;
        private string email;
        private string phoneNumber;

        /* Getters and Setters */
        public UserName GetName()
        {
            return name;
        }

        public void SetName(UserName value)
        {
            name = value;
        }

        public Address GetAddress()
        {
            return address;
        }

        public void SetAddress(Address value)
        {
            address = value;
        }

        public int GetCid()
        {
            return cid;
        }

        public void SetCid(int value)
        {
            cid = value;
        }

        public string GetEmail()
        {
            return email;
        }

        public void SetEmail(string value)
        {
            email = value;
        }

        public string GetPhoneNumber()
        {
            return phoneNumber;
        }

        public void SetPhoneNumber(string value)
        {
            phoneNumber = value;
        }
    }

}
