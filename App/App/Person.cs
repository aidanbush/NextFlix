using System;

namespace App
{
    class Person
    {
        private int cid;
        // name
        // address
        private string email;
        private string phoneNumber;

        /* Getters and Setters */
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
