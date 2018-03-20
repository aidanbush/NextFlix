using System;
using System.IO;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;

namespace App
{
    internal static class DBEnvironment
    {
        private static SqlConnection con; 
        private static SqlDataAdapter sda;
        private static BindingList<Customer> customers;
        private static BindingList<Employee> employees;
        private static BindingList<Movie> movies;


        public static BindingList<Customer> GetCustomers()
        {
            return customers;
        }

        public static void SetCustomers()
        {
            customers = RetrieveCustomers();
        }

        public static BindingList<Employee> GetEmployees()
        {
            return employees;
        }

        public static void SetEmployees()
        {
            employees = RetrieveEmployees();
        }

        internal static BindingList<Movie> GetMovies()
        {
            return movies;
        }
   
        internal static void SetMovies()
        {
            movies = RetrieveMovies();
        }

        public static void ConnectToDB()
        {
            string conn = getConnectionString();
            con = new SqlConnection(conn);
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
                Customer.AccountType account = Customer.AccountType.Limited;
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


                ContactInformation contactInfo = new ContactInformation(null, employeeRow["phone_number"].ToString());
                Employee.Position position = Employee.Position.Employee;
                if (employeeRow["position"].ToString() == "Manager")
                {
                    position = Employee.Position.Manager;
                }
                Employee e = new Employee(name, address, contactInfo, float.Parse(employeeRow["wage"].ToString(), CultureInfo.InvariantCulture.NumberFormat), DateTime.Now, employeeRow["social_insurance_num"].ToString(), position);
                e.Id = int.Parse(employeeRow["eid"].ToString());

                employeeList.Add(e);
            }

            return employeeList;
        }

        private static BindingList<Movie> RetrieveMovies()
        {
            string qString = "SELECT * FROM movie";
            SqlDataAdapter adaptor = new SqlDataAdapter(qString, con);
            DataTable movieTable = new DataTable();
            adaptor.Fill(movieTable);
            BindingList<Movie> movies = new BindingList<Movie>();

            foreach (DataRow movieRow in movieTable.Rows)
            {

                string name = movieRow["name"].ToString();
                string genre = movieRow["genre"].ToString();
                float fees = float.Parse(movieRow["fees"].ToString());
                int num_copies = int.Parse(movieRow["num_copies"].ToString());
                int copies = int.Parse(movieRow["copies_available"].ToString());
                
                //rating don't work?
                //movieRow["rating"].ToString();

                Movie m = new Movie(name, genre, fees, num_copies, copies, 1);
      
                movies.Add(m);
                
            }
            return movies;
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