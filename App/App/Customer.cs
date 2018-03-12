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
            Address = newAddress;
            Name = newName;
            Type = newType;
            ContactInformation = contactInformation;
        }

        /* Getters and Setters */
        public DateTime CreationDate { get => creationDate; set => creationDate = value; }
        public int Rating { get => rating; set => rating = value; }
        public string CreditCard { get => creditCard; set => creditCard = value; }
        public AccountType Type { get => type; set => type = value; }

        /* function Overrides */
        public override string ToString()
        {
            return Id.ToString() + " " + Name.ToString() + " " + Type.ToString();
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
                    command.Parameters.AddWithValue("@first_name", this.Name.GetFirstName());
                    command.Parameters.AddWithValue("@last_name", this.Name.GetLastName());
                    command.Parameters.AddWithValue("@creation_date", DateTime.Now);
                    command.Parameters.AddWithValue("@account_type", this.GetType().ToString());
                    command.Parameters.AddWithValue("@phone_number", this.ContactInformation.getPhoneNumber());
                    command.Parameters.AddWithValue("@email", this.ContactInformation.getEmail());
                    command.Parameters.AddWithValue("@suite_number", this.Address.GetSuiteNumber());
                    command.Parameters.AddWithValue("@street_number", this.Address.GetStreetNumber());
                    command.Parameters.AddWithValue("@house_number", this.Address.GetHouseNumber());
                    command.Parameters.AddWithValue("@postalcode", this.Address.GetPostal());
                    command.Parameters.AddWithValue("@city", this.Address.GetCity());
                    command.Parameters.AddWithValue("@province", this.Address.GetProvince());
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