using System;

namespace App
{
    public abstract class Person
    {
        private int id;
        private UserName name;
        private ContactInformation contactInformation;
        private Address address;

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

        public int GetID()
        {
            return id;
        }

        public void SetID(int value)
        {
            id = value;
        }

        public string GetPhoneNumber()
        {
            return contactInformation.getPhoneNumber();
        }

        public string GetEmail()
        {
            return contactInformation.getEmail();
        }

        public void SetContactInformation(ContactInformation value)
        {
            contactInformation = value;
        }
    }

}
