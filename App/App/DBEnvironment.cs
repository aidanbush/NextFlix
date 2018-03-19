using System;
using System.IO;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;

namespace App
{
    internal static class DBEnvironment
    {
        private static SqlConnection con; 
        private static SqlDataAdapter sda;
        private static DataSet ds;
        private static BindingList<Customer> customers;

        public static BindingList<Customer> GetCustomers()
        {
            return customers;
        }

        public static void SetCustomers()
        {
            customers = RetrieveCustomers();
        }

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

        public static bool Add(IQuery queryObject)
        {
            return queryObject.Add(con);
        }
        public static bool Edit(IQuery queryObject)
        {
            return queryObject.Edit(con);
        }
        public static bool Delete(IQuery queryObject)
        {
            return queryObject.Delete(con);
        }
     
        public static DataSet getDataSet(string dataSet)
        {
            DataSet ds = new DataSet();
            sda.Fill(ds, dataSet);
            return ds;
        }

        public static BindingList<Customer> RetrieveCustomers()
        {
            BindingList<Customer> customers = new BindingList<Customer>();

            string qString = "SELECT * FROM customer";
            SqlDataAdapter adaptor = new SqlDataAdapter(qString, con);

            DataTable customerTable = new DataTable();
            adaptor.Fill(customerTable);

            foreach(DataRow customerRow in customerTable.Rows) {
                UserName name = new UserName(customerRow["first_name"].ToString(), customerRow["last_name"].ToString());
                Address address = new Address(customerRow["suite_number"].ToString(), customerRow["street_number"].ToString(),
                                              customerRow["house_number"].ToString(), customerRow["city"].ToString(),
                                              customerRow["province"].ToString(), customerRow["postalcode"].ToString());
                Customer.AccountType account = Customer.AccountType.Limited; ;
                switch (customerRow["account_type"].ToString())
                {
                    case "Disabled":
                        account = Customer.AccountType.Disabled;
                        break;
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

                ContactInformation newContact = new ContactInformation(customerRow["email"].ToString(), customerRow["phone_number"].ToString());
                Customer customer = new Customer(name, address, newContact, account);
                customer.CreationDate = (DateTime)customerRow["creation_date"];
                customer.Id = (int)customerRow["cid"];

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