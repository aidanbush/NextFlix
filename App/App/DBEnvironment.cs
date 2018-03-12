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

        public static DataSet query()
        {
            con.Open();
            String q = "insert into customer(first_name, last_name, account_type, creation_date, phone_number, email)" +
               "values (@first_name, @last_name, @account_type, @creation_date, @phone_number, @email)";

            using (SqlCommand command = new SqlCommand(q, con))
            {

                command.Parameters.AddWithValue("@first_name", "abc");
                command.Parameters.AddWithValue("@last_name", "abc");
                command.Parameters.AddWithValue("@creation_date", DateTime.Now);
                command.Parameters.AddWithValue("@account_type", "Limited");
                command.Parameters.AddWithValue("@phone_number", 7806679099);
                command.Parameters.AddWithValue("@email", "abc@gmaail.com");

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
    }
}