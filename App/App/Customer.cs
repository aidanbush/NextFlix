using System;
using System.Data.SqlClient;
using System.Diagnostics;

namespace App
{
    public class Customer : Person, IQuery
    {
        public enum AccountType {Disabled, Limited, Bronze, Silver, Gold};
        private AccountType type;
        private DateTime creationDate;
        private string creditCard;
        private int rating;

        public Customer(UserName newName, Address newAddress, ContactInformation contactInformation, AccountType newType)
        {
            SetAddress(newAddress);
            SetName(newName);
            SetType(newType);
            SetContactInformation(contactInformation);
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


        public bool Add(SqlConnection con)
        {
            con.Open();
            String q = "insert into customer(first_name, last_name, account_type, creation_date, phone_number, email, suite_number, street_number, house_number, postalcode, city, province)" +
               "values (@first_name, @last_name, @account_type, @creation_date, @phone_number, @email, @suite_number, @street_number, @house_number, @postalcode, @city, @province)";

            using (SqlCommand command = new SqlCommand(q, con))
            {
                try
                {
                    command.Parameters.AddWithValue("@first_name", this.GetName().GetFirstName());
                    command.Parameters.AddWithValue("@last_name", this.GetName().GetLastName());
                    command.Parameters.AddWithValue("@creation_date", DateTime.Now);
                    command.Parameters.AddWithValue("@account_type", this.GetType().ToString());
                    command.Parameters.AddWithValue("@phone_number", this.GetPhoneNumber());
                    command.Parameters.AddWithValue("@email", this.GetEmail());
                    command.Parameters.AddWithValue("@suite_number", this.GetAddress().GetSuiteNumber());
                    command.Parameters.AddWithValue("@street_number", this.GetAddress().GetStreetNumber());
                    command.Parameters.AddWithValue("@house_number", this.GetAddress().GetHouseNumber());
                    command.Parameters.AddWithValue("@postalcode", this.GetAddress().GetPostal());
                    command.Parameters.AddWithValue("@city", this.GetAddress().GetCity());
                    command.Parameters.AddWithValue("@province", this.GetAddress().GetProvince());
                    int err = command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Debug.Print(e.ToString());
                    con.Close();
                    return false;
                }

            }
            con.Close();
            return true;
        }

        public bool Edit(SqlConnection con)
        {
            throw new NotImplementedException();
        }

        public bool Delete(SqlConnection con)
        {
            throw new NotImplementedException();
        }
    }
}