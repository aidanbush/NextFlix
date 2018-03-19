using System;
using System.Data.SqlClient;
using System.Diagnostics;

namespace App
{
    public class Employee : Person, IQuery
    {
        public enum Position {Employee, Manager};
        private Position position;
        private float wage;
        private DateTime startDate;
        private string sin;

        public Employee(UserName newName, Address newAddress, ContactInformation contact, float newWage, DateTime newStart, string newSIN, Position newPosition)
        {
            Address = newAddress;
            Name =newName;
            EmployeePosition = newPosition;
            Wage = newWage;
            StartDate = newStart;
            SIN = newSIN;
            ContactInformation = contact;
        }

        /* Getters and Setters */
        public Position EmployeePosition { get => position; set => position = value; }
        public float Wage { get => wage; set => wage = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public string SIN { get => sin; set => sin = value; }
        
        public bool Add(SqlConnection con)
        {

            con.Open();
            String q = "insert into customer(first_name, last_name, account_type, creation_date, phone_number, email, suite_number, street_number, house_number, postalcode, city, province, wage, start, social_insurance_num)" +
               "values (@first_name, @last_name, @account_type, @creation_date, @phone_number, @email, @suite_number, @street_number, @house_number, @postalcode, @city, @province, @wage, @start, @social_insurance_num)";

            using (SqlCommand command = new SqlCommand(q, con))
            {
                try
                {
                    command.Parameters.AddWithValue("@first_name", this.Name.FirstName);
                    command.Parameters.AddWithValue("@last_name", this.Name.LastName);
                    command.Parameters.AddWithValue("@creation_date", DateTime.Now);
                    command.Parameters.AddWithValue("@phone_number", this.ContactInformation.PhoneNumber);
                    command.Parameters.AddWithValue("@suite_number", this.Address.SuiteNumber);
                    command.Parameters.AddWithValue("@street_number", this.Address.StreetNumber);
                    command.Parameters.AddWithValue("@house_number", this.Address.HouseNumber);
                    command.Parameters.AddWithValue("@postalcode", this.Address.PostalCode);
                    command.Parameters.AddWithValue("@city", this.Address.City);
                    command.Parameters.AddWithValue("@wage", this.wage);
                    command.Parameters.AddWithValue("@start", this.startDate);
                    command.Parameters.AddWithValue("@province", this.Address.Province);
                    command.Parameters.AddWithValue("@social_insurance_num", this.SIN);

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