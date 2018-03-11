using System;

namespace App
{
    public class Customer : Person
    {
        enum accountType {Limited, Bronze, Silver, Gold};
        private accountType type;
        private DateTime creationDate;
        private string creditCard;
        private int rating;

        public Customer(string newEmail, accountType newType)
        {
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

        private accountType GetType()
        {
            return type;
        }

        private void SetType(accountType value)
        {
            type = value;
        }
    }
}