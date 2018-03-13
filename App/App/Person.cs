using System;

namespace App
{
    public abstract class Person
    {
        private int id;
        private UserName name;
        private Address address;
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
            return id;
        }

        public void SetCid(int value)
        {
            id = value;
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
