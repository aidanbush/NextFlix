using System;
using System.IO;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace App
{
    internal static class DBEnvironment
    {
        private static SqlConnection con; 
        private static SqlDataAdapter sda;
        private static DataSet ds;

        public static DataSet ConnectToDB()
        {
            string conn = getConnectionString();
            con = new SqlConnection(conn);
            sda = new SqlDataAdapter("SELECT * FROM customer", conn);
            return ds;
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

        public static DataSet CustomerInsertionQuery(CustomerInsertionParameters parameters)
        {
            UserName name = parameters.GetUserName();
            Address address = parameters.GetAddress();
            ContactInformation info = parameters.GetContactInformation();

            con.Open();
            String q = "insert into customer(first_name, last_name, account_type, creation_date, phone_number, email, suite_number, street_number, house_number, postalcode, city, province)" +
               "values (@first_name, @last_name, @account_type, @creation_date, @phone_number, @email, @suite_number, @street_number, @house_number, @postalcode, @city, @province)";

            using (SqlCommand command = new SqlCommand(q, con))
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
                if (err < 0)
                {
                    Debug.Print("InserFailed");
                }
            }
            
            con.Close();
            return ds;

        }

        public static DataSet getDataSet()
        {
            DataSet ds = new DataSet();
            sda.Fill(ds, "Customers");
            return ds;
        }

        public static void RetrieveCustomers()
        {
            string qString = "SELECT * FROM customer";
            SqlDataAdapter adaptor = new SqlDataAdapter(qString, con);

            DataSet customers = new DataSet();
            adaptor.Fill(customers);
        }
    }
}