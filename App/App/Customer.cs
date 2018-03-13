using System;

namespace App
{
    public class Customer : Person
    {
        public enum AccountType {Disabled, Limited, Bronze, Silver, Gold};
        private AccountType type;
        private DateTime creationDate;
        private string creditCard;
        private int rating;

        public Customer(UserName newName, Address newAddress, string newEmail, AccountType newType)
        {
            Address = newAddress;
            Name = newName;
            Type = newType;
            Email = newEmail;
        }

        /* Getters and Setters */
        public DateTime CreationDate { get => creationDate; set => creationDate = value; }
        public int Rating { get => rating; set => rating = value; }
        public string CreditCard { get => creditCard; set => creditCard = value; }
        public AccountType Type { get => type; set => type = value; }

        /* function Overrides */
        public override string ToString()
        {
            return Cid.ToString() + " " + Name.ToString() + " " + Type.ToString();
        }

    }
}