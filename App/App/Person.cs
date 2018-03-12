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
        public int Id { get => id; set => id = value; }
        public UserName Name { get => name; set => name = value; }
        public ContactInformation ContactInformation { get => contactInformation; set => contactInformation = value; }
        public Address Address { get => address; set => address = value; }
    }

}
