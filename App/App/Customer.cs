using System;

namespace App
{
    public class Customer : Person
    {
        public enum AccountType {Limited, Bronze, Silver, Gold};
        private AccountType type;
        private DateTime creationDate;
        private string creditCard;
        private int rating;

        public Customer(UserName newName, Address newAddress, string newEmail, AccountType newType)
        {
            SetAddress(newAddress);
            SetName(newName);
            SetType(newType);
            SetEmail(newEmail);
        }

        /* Getters and Setters */
        public int GetRating()
        {
            return rating;
        }

        public void SetRating(int value)
        {
            rating = value;
        }

        public string GetcreditCard()
        {
            return creditCard;
        }

        public void SetcreditCard(string value)
        {
            creditCard = value;
        }

        public AccountType GetType()
        {
            return type;
        }

        public void SetType(AccountType value)
        {
            type = value;
        }

        public DateTime GetCreationDate()
        {
            return creationDate;
        }

        public void SetCreationDate(DateTime value)
        {
            creationDate = value;
        }
    }
}