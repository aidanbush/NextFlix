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
        private Object CheckNulls(String value)
        {
            Console.WriteLine("checking " + value);
            if(value == null)
            {
                Console.WriteLine("Insert Null for code/email");
                return DBNull.Value;
            }
            else
            {
                Console.WriteLine("Return " + value);
                return value.ToString();
            }
        }

        private bool AddEdit(String queryString, SqlConnection con)
        {
            con.Open();
            using (SqlCommand command = new SqlCommand(queryString, con))
            {
                try
                {
                    command.Parameters.AddWithValue("@first_name", this.Name.FirstName);
                    command.Parameters.AddWithValue("@last_name", this.Name.LastName);
                    command.Parameters.AddWithValue("@creation_date", DateTime.Now);
                    command.Parameters.AddWithValue("@account_type", this.Type.ToString());
                    command.Parameters.AddWithValue("@phone_number", CheckNulls(this.ContactInformation.PhoneNumber));
                    command.Parameters.AddWithValue("@email", CheckNulls(this.ContactInformation.Email));
                    command.Parameters.AddWithValue("@suite_number", this.Address.SuiteNumber);
                    command.Parameters.AddWithValue("@street_number", this.Address.StreetNumber);
                    command.Parameters.AddWithValue("@house_number", this.Address.HouseNumber);
                    command.Parameters.AddWithValue("@postalcode", CheckNulls(this.Address.PostalCode));
                    command.Parameters.AddWithValue("@city", this.Address.City);
                    command.Parameters.AddWithValue("@province", this.Address.Province);
                    command.Parameters.AddWithValue("@cid", this.Id);
                    command.Parameters.AddWithValue("@username", this.Credentials.Username);
                    command.Parameters.AddWithValue("@passhash", this.Credentials.PassHash);

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
        
        public int GetMoviesAllowedAtATime()
        {
            int count;

            switch (type)
            {
                case (AccountType.Bronze):
                    count = 1;
                    break;
                case (AccountType.Silver):
                    count = 2;
                    break;
                case (AccountType.Gold):
                    count = 3;
                    break;
                case (AccountType.Limited):
                    count = 1;
                    break;
                default:
                    count = 0;
                    break;  
            }

            return count;
        }
        public int GetMoviesRentablePerMonth()
        {
            int count;
            switch (type)
            {
                case (AccountType.Limited):
                    count = 2;
                    break;
                case (AccountType.Disabled):
                    count = 0;
                    break;
                default:
                    //3 have unlimited rentals
                    count = 3;
                    break;
            }
            return count;
        }
        public bool Add(SqlConnection con)
        {
            if(this.Address.PostalCode == "")
            {
                this.Address.PostalCode = null;
            }
            if(this.ContactInformation.Email == "")
            {
                this.ContactInformation.Email = null;
            }
            String qString = "insert into customer(first_name, last_name, account_type, creation_date, phone_number, email, suite_number, street_number, house_number, postalcode, city, province, username, passhash)" +
               "values (@first_name, @last_name, @account_type, @creation_date, @phone_number, @email, @suite_number, @street_number, @house_number, @postalcode, @city, @province, @username, @passhash)";

            return AddEdit(qString, con);
        }

        public bool Edit(SqlConnection con)
        {
<<<<<<< HEAD
            if (this.Address.PostalCode == "")
            {
                this.Address.PostalCode = null;
            }
            if (this.ContactInformation.Email == "")
            {
                this.ContactInformation.Email = null;
            }
            if (this.ContactInformation.PhoneNumber == "")
            {
                this.ContactInformation.PhoneNumber = null;
            }
            String q = "UPDATE customer SET first_name=@first_name, " + 
=======
            
            String qString = "UPDATE customer SET first_name=@first_name, " + 
>>>>>>> bb252f7dec74aa9e6dfbac6cb1bf535ee676403d
                    "last_name=@last_name, " + 
                    "phone_number=@phone_number, " + 
                    "email=@email, " + 
                    "suite_number=@suite_number, " + 
                    "street_number=@street_number, " +
                    "house_number=@house_number, " +
                    "postalcode=@postalcode, " +
                    "city=@city, " +
                    "province=@province, " +
                    "account_type=@account_type " +
                    //"passhash=@passhash" +
                    "WHERE cid=@cid";

            return AddEdit(qString, con);
        }

        public bool Delete(SqlConnection con)
        {
            String q = "DELETE FROM customer WHERE cid=@cid";

            con.Open();
            using (SqlCommand command = new SqlCommand(q, con))
            {
                try
                {
                    command.Parameters.AddWithValue("@cid", this.Id);
                    int err = command.ExecuteNonQuery();
                }

                catch (Exception e)
                {
                    con.Close();
                    Console.WriteLine("Database failed to delete record");
                    return false;
                }
            }
            con.Close();
            return true;
            
        }

        public bool AddToQueue(SqlConnection con)
        {
            throw new NotImplementedException();
        }
    }
}