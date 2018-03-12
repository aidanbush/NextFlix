using System;
using System.IO;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Collections.Generic;

namespace App
{
    internal static class DBEnvironment
    {
        private static SqlConnection con; 
        private static SqlDataAdapter sda;
        private static DataSet ds;

        public static void ConnectToDB()
        {
            string conn = getConnectionString();
            con = new SqlConnection(conn);
            sda = new SqlDataAdapter("SELECT * FROM customer", conn);
        }

        private static string getConnectionString()
        {
            string path = Path.GetFullPath(@"App");
            string path2 = Path.Combine(path, @"..\..\..\conn.txt");
            string connectionString = "";
            using (StreamReader sr = new StreamReader(path2))
            {
                while (sr.Peek() >= 0)
                {
                    connectionString = sr.ReadLine();
                }
            }

            return connectionString;
        }

        public static bool CustomerInsertionQuery(CustomerInsertionParameters parameters)
        {
            UserName name = parameters.GetUserName();
            Address address = parameters.GetAddress();
            ContactInformation info = parameters.GetContactInformation();

            con.Open();
            String q = "insert into customer(first_name, last_name, account_type, creation_date, phone_number, email, suite_number, street_number, house_number, postalcode, city, province)" +
               "values (@first_name, @last_name, @account_type, @creation_date, @phone_number, @email, @suite_number, @street_number, @house_number, @postalcode, @city, @province)";

            using (SqlCommand command = new SqlCommand(q, con))
            {
                try
                {
                    command.Parameters.AddWithValue("@first_name", name.GetFirstName());
                    command.Parameters.AddWithValue("@last_name", name.GetLastName());
                    command.Parameters.AddWithValue("@creation_date", DateTime.Now);
                    command.Parameters.AddWithValue("@account_type", "Limited");
                    command.Parameters.AddWithValue("@phone_number", info.getPhoneNumber());
                    command.Parameters.AddWithValue("@email", info.getEmail());
                    command.Parameters.AddWithValue("@suite_number", address.GetSuiteNumber());
                    command.Parameters.AddWithValue("@street_number", address.GetStreetNumber());
                    command.Parameters.AddWithValue("@house_number", address.GetHouseNumber());
                    command.Parameters.AddWithValue("@postalcode", address.GetPostal());
                    command.Parameters.AddWithValue("@city", address.GetCity());
                    command.Parameters.AddWithValue("@province", address.GetProvince());
                    int err = command.ExecuteNonQuery();
                }
                catch(Exception e)
                {
                    Debug.Print(e.ToString());
                    con.Close();
                    return false;
                }
              
            }           
            con.Close();
            return true;

        }
        public static DataSet getDataSet()
        {
            DataSet ds = new DataSet();
            sda.Fill(ds, "Customers");
            return ds;
        }

        public static List<Customer> RetrieveCustomers()
        {
            List<Customer> customers = new List<Customer>();

            string qString = "SELECT * FROM customer";
            SqlDataAdapter adaptor = new SqlDataAdapter(qString, con);

            DataTable customerTable = new DataTable();
            adaptor.Fill(customerTable);

            foreach(DataRow customerRow in customerTable.Rows) {
                UserName name = new UserName((string)customerRow["first_name"], (string)customerRow["last_name"]);
                Address address = new Address((string)customerRow["suite_number"], (string)customerRow["street_number"],
                                              (string)customerRow["house_number"], (string)customerRow["city"],
                                              (string)customerRow["province"], (string)customerRow["postalcode"]);
                Customer.AccountType account = Customer.AccountType.Limited; ;
                switch ((string)customerRow["account_type"])
                {
                    case "Limited":
                        account = Customer.AccountType.Limited;
                        break;
                    case "Bronze":
                        account = Customer.AccountType.Bronze;
                        break;
                    case "Silver":
                        account = Customer.AccountType.Silver;
                        break;
                    case "Gold":
                        account = Customer.AccountType.Gold;
                        break;
                    default:
                        Debug.Write("Read customer without account type.");
                        continue;
                }
                
                Customer customer = new Customer(name, address, (string)customerRow["email"], account);
                customer.SetCreationDate((DateTime)customerRow["creation_date"]);

                customers.Add(customer);
            }

            return customers;
        }

        public static void UpdateRatings()
        {
            con.Open();

            // setup stored procedure call
            SqlCommand cmd = new SqlCommand("calc_cust_rating", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}