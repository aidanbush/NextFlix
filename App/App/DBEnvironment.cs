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
        private static BindingList<Customer> customers;
        private static BindingList<Employee> employees;

        public static BindingList<Customer> GetCustomers()
        {
            return customers;
        }

        public static void SetCustomers()
        {
            customers = RetrieveCustomers();
        }

        public static void SetEmployees()
        {
            employees = RetrieveEmployees();
        }
        public static BindingList<Employee> GetEmployees()
        {
            return employees;
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
        //Depricated remove when meet with Jordan
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
                    command.Parameters.AddWithValue("@first_name", name.FirstName);
                    command.Parameters.AddWithValue("@last_name", name.LastName);
                    command.Parameters.AddWithValue("@creation_date", DateTime.Now);
                    command.Parameters.AddWithValue("@account_type", Customer.AccountType.Limited);
                    command.Parameters.AddWithValue("@phone_number", info.PhoneNumber);
                    command.Parameters.AddWithValue("@email", info.Email);
                    command.Parameters.AddWithValue("@suite_number", address.SuiteNumber);
                    command.Parameters.AddWithValue("@street_number", address.StreetNumber);
                    command.Parameters.AddWithValue("@house_number", address.HouseNumber);
                    command.Parameters.AddWithValue("@postalcode", address.PostalCode);
                    command.Parameters.AddWithValue("@city", address.City);
                    command.Parameters.AddWithValue("@province", address.Province);

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

        private static BindingList<Employee>  RetrieveEmployees()
        {


            BindingList<Employee> employeeList = new BindingList<Employee>();

            string qString = "SELECT * FROM employee";
            SqlDataAdapter adaptor = new SqlDataAdapter(qString, con);

            DataTable employeeTable = new DataTable();
            adaptor.Fill(employeeTable);

            foreach (DataRow employeeRow in employeeTable.Rows)
            {
                
                UserName name = new UserName(employeeRow["first_name"].ToString(), employeeRow["last_name"].ToString());

                Address address = new Address(employeeRow["suite_number"].ToString(), employeeRow["street_number"].ToString(),
                                              employeeRow["house_number"].ToString(), employeeRow["city"].ToString(),
                                              employeeRow["province"].ToString(), employeeRow["postalcode"].ToString());


                ContactInformation contactInfo = new ContactInformation(employeeRow["email"].ToString(), employeeRow["phone_number"].ToString());
                Employee.Position position = Employee.Position.Employee;
                if (employeeRow["position"].ToString() == "Manager")
                {
                    position = Employee.Position.Manager;
                }
                Employee e = new Employee(name, address, contactInfo, (float)employeeRow["wage"], (DateTime)employeeRow["start"], employeeRow["phone_number"].ToString(), position);

                employeeList.Add(e);
            }

            return employeeList;
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