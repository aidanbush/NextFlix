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

        public Customer(UserName newName, Address newAddress, ContactInformation contactInformation, Customer.AccountType newType)
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
        public bool AddEdit(String queryString, SqlConnection con)
        {
            con.Open();
            bool flag = true;
            Console.WriteLine(this.Name.LastName);
            using (SqlCommand command = new SqlCommand(queryString, con))
            {
                try
                {
                    command.Parameters.AddWithValue("@first_name", this.Name.FirstName);
                    command.Parameters.AddWithValue("@last_name", this.Name.LastName);
                    command.Parameters.AddWithValue("@creation_date", DateTime.Now);
                    command.Parameters.AddWithValue("@account_type", this.Type.ToString());
                    command.Parameters.AddWithValue("@phone_number", this.ContactInformation.PhoneNumber);
                    command.Parameters.AddWithValue("@email", this.ContactInformation.Email);
                    command.Parameters.AddWithValue("@suite_number", this.Address.SuiteNumber);
                    command.Parameters.AddWithValue("@street_number", this.Address.StreetNumber);
                    command.Parameters.AddWithValue("@house_number", this.Address.HouseNumber);
                    command.Parameters.AddWithValue("@postalcode", this.Address.PostalCode);
                    command.Parameters.AddWithValue("@city", this.Address.City);
                    command.Parameters.AddWithValue("@province", this.Address.Province);
                    if (flag == true)
                    {
                        Console.WriteLine("GETTING ID");
                        command.Parameters.AddWithValue("@cid", this.Id);
                    }
                    int err = command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    Debug.Print(e.ToString());
                    con.Close();
                    return false;
                }

            }
            con.Close();
            Console.WriteLine("Database edit successful");
            return true;
        }
        public bool Add(SqlConnection con)
        {

            String q = "insert into customer(first_name, last_name, account_type, creation_date, phone_number, email, suite_number, street_number, house_number, postalcode, city, province)" +
               "values (@first_name, @last_name, @account_type, @creation_date, @phone_number, @email, @suite_number, @street_number, @house_number, @postalcode, @city, @province)";

            if(AddEdit(q, con))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool Edit(SqlConnection con)
        {
            String q = "UPDATE customer SET first_name=@first_name, last_name=@last_name" +
                    " WHERE cid=@cid";
            Console.WriteLine("ACCOUNT ID = " + this.Id);
            if (AddEdit(q, con))
            {

                Console.WriteLine("User updated");
                return true;
            }
            else
            {
                Console.WriteLine("User could not be updated");
                return false;
            }
        }

        public bool Delete(SqlConnection con)
        {
            throw new NotImplementedException();
        }
    }
}