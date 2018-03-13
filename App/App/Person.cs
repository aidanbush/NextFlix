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
        public int Cid { get => cid; set => cid = value; }
        public UserName Name { get => name; set => name = value; }
        public Address Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
    }

}
