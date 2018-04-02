using System;

namespace App
{
    public abstract class Person
    {
        private int id;
        private UserName name;
        private ContactInformation contactInformation;
        private Address address;
        private Credentials credentials;

        /* Getters and Setters */
        public int Id { get => id; set => id = value; }
        public UserName Name { get => name; set => name = value; }
        public ContactInformation ContactInformation { get => contactInformation; set => contactInformation = value; }
        public Address Address { get => address; set => address = value; }
        public Credentials Credentials { get => credentials; set => credentials = value; }

        /* name getters */
        public string FirstName { get => name.FirstName; }
        public string LastName { get => name.LastName; }

        /* address getters */
        public string SuiteNumber { get => address.SuiteNumber; }
        public string StreetNumber { get => address.StreetNumber; }
        public string HouseNumber { get => address.HouseNumber; }
        public string City { get => address.City; }
        public string Province { get => address.Province; }
        public string PostalCode { get => address.PostalCode; }
    }

}
