using System;
using System.IO;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Security.Cryptography;

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

        public static bool AddToQueue(IQuery queryObject)
        {
            return queryObject.AddToQueue(con);
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

            foreach (DataRow customerRow in customerTable.Rows) {
                UserName name = new UserName(customerRow["first_name"].ToString(), customerRow["last_name"].ToString());
                String postalCode;
                try
                {
                    postalCode = customerRow["postalcode"].ToString();
                }
                catch(PostalCodeException)
                {
                    postalCode = "";
                }

                Address address = new Address(customerRow["suite_number"].ToString(), customerRow["street_number"].ToString(),
                                              customerRow["house_number"].ToString(), customerRow["city"].ToString(),
                                              customerRow["province"].ToString(), postalCode);
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

        private static BindingList<Employee> RetrieveEmployees()
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
        public static BindingList<Queue> RetrieveAllQueue()
        {
            //THis is wrong??????
            string query = "SELECT * FROM queue ORDER BY date_added";

            SqlDataAdapter adaptor = new SqlDataAdapter(query, con);
            DataTable queueTable = new DataTable();
            adaptor.Fill(queueTable);
            BindingList<Queue> queue = new BindingList<Queue>();

            foreach (DataRow queueRow in queueTable.Rows)
            {
                int cid = int.Parse(queueRow["cid"].ToString());
                int mid = int.Parse(queueRow["mid"].ToString());
                DateTime date = DateTime.Parse(queueRow["date_added"].ToString());
                Queue newQueue = new Queue(cid, mid, date);
                queue.Add(newQueue);
                
            }
                return queue;

        }

        public static BindingList<Movie> RetrieveCustomerQueue(Customer user)
        {
            int cid = user.Id;

            string query = "select * from movie " +
                           "WHERE mid IN " +
                           "(SELECT mid from queue WHERE cid=" + cid + ")";
           
            SqlDataAdapter adaptor = new SqlDataAdapter(query, con);
            DataTable queueTable = new DataTable();
            adaptor.Fill(queueTable);
            BindingList<Movie> queue = GetMoviesFromQuery(queueTable);
            
            return queue;

        }
        private static BindingList<Movie> GetMoviesFromQuery(DataTable movieTable)
        {
            BindingList<Movie> movies = new BindingList<Movie>();

            foreach (DataRow movieRow in movieTable.Rows)
            {

                string name = movieRow["name"].ToString();
                string genre = movieRow["genre"].ToString();
                float fees = float.Parse(movieRow["fees"].ToString());
                int num_copies = int.Parse(movieRow["num_copies"].ToString());
                int copies = int.Parse(movieRow["copies_available"].ToString());
                int id = (int)movieRow["mid"];
                //rating don't work?
                //movieRow["rating"].ToString();
                Movie movie = new Movie(name, genre, fees, num_copies, copies, 1);
                movie.Id = id;
                movies.Add(movie);
            }
            return movies;
        }
        private static BindingList<Movie> RetrieveMovies()
        {
            string qString = "SELECT * FROM movie";
            SqlDataAdapter adaptor = new SqlDataAdapter(qString, con);
            DataTable movieTable = new DataTable();
            adaptor.Fill(movieTable);
            BindingList<Movie> movies = GetMoviesFromQuery(movieTable);
            return movies;
        }

        public static BindingList<Order> RetrieveUnfulfilledOrders()
        {
            Debug.WriteLine("Retrieveing orders");

            string qString = "SELECT * FROM [order] where eid is NULL";
            SqlDataAdapter adapter = new SqlDataAdapter(qString, con);
            DataTable orderTable = new DataTable();
            adapter.Fill(orderTable);
            BindingList<Order> orders = new BindingList<Order>();

            foreach (DataRow orderRow in orderTable.Rows)
            {
                Debug.WriteLine("new order");
                int oid = (int)orderRow["oid"];
                int mid = (int)orderRow["mid"];
                int cid = (int)orderRow["cid"];
                DateTime placedDate = (DateTime)orderRow["order_placed"];

                Order order = new Order(mid, cid, 0)
                {
                    Id = oid,
                    PlacedDate = placedDate
                };

                orders.Add(order);
            }

            return orders;
        }

        public static bool FulfillOrder(int oid, int eid)
        {
            string qString = "UPDATE [order] SET eid = @eid WHERE oid = @oid";

            con.Open();
            using (SqlCommand command = new SqlCommand(qString, con))
            {
                try
                {
                    command.Parameters.AddWithValue("@eid", eid);
                    command.Parameters.AddWithValue("@oid", oid);
                    int err = command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    con.Close();
                    return false;
                }

            }
            con.Close();
            return true;
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

        public static Movie GetMovieByID(int id)
        {
            string qString = "SELECT * FROM movie WHERE mid = @id";
            SqlDataAdapter adapter = new SqlDataAdapter(qString, con);
            adapter.SelectCommand.Parameters.AddWithValue("@id", id);

            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                DataRow row = table.Rows[0];
                return CreateMovieFromRow(row);
            }

            return null;
        }

        public static Employee GetEmployeeByID(int id)
        {
            string qString = "SELECT * FROM employee WHERE eid = @id";
            SqlDataAdapter adapter = new SqlDataAdapter(qString, con);
            adapter.SelectCommand.Parameters.AddWithValue("@id", id);

            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                DataRow row = table.Rows[0];
                return CreateEmployeeFromRow(row);
            }

            return null;
        }

        public static Customer GetCustomerByID(int id)
        {
            string qString = "SELECT * FROM customer WHERE cid = @id";
            SqlDataAdapter adapter = new SqlDataAdapter(qString, con);
            adapter.SelectCommand.Parameters.AddWithValue("@id", id);

            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                DataRow row = table.Rows[0];
                return CreateCustomerFromRow(row);
            }

            return null;
        }

        public static Customer ValidateCustomer(string username, string passhash)
        {
            string qString = "SELECT * FROM customer WHERE cid IN (SELECT cid from customer_accounts WHERE username LIKE @username and passhash LIKE @passhash)";
            SqlDataAdapter adapter = new SqlDataAdapter(qString, con);
            adapter.SelectCommand.Parameters.AddWithValue("@username", username);
            adapter.SelectCommand.Parameters.AddWithValue("@passhash", passhash);

            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                DataRow row = table.Rows[0];
                Customer customer = CreateCustomerFromRow(row);
                return customer;
            }

            return null;
        }

        public static Employee ValidateEmployee(string username, string passhash)
        {
            string qString = "SELECT * FROM employee WHERE eid IN (SELECT eid from employee_accounts WHERE username LIKE @username and passhash LIKE @passhash)";
            SqlDataAdapter adapter = new SqlDataAdapter(qString, con);
            adapter.SelectCommand.Parameters.AddWithValue("@username", username);
            adapter.SelectCommand.Parameters.AddWithValue("@passhash", passhash);

            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                DataRow row = table.Rows[0];
                Employee employee = CreateEmployeeFromRow(row);
                return employee;
            }

            return null;
        }

        public static Employee ValidateManager(string username, string passhash)
        {
            string qString = "SELECT * FROM employee WHERE eid IN (SELECT eid from employee_accounts WHERE username LIKE @username AND passhash LIKE @passhash) AND position = 'manager'";
            SqlDataAdapter adapter = new SqlDataAdapter(qString, con);
            adapter.SelectCommand.Parameters.AddWithValue("@username", username);
            adapter.SelectCommand.Parameters.AddWithValue("@passhash", passhash);

            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                DataRow row = table.Rows[0];
                Employee employee = CreateEmployeeFromRow(row);
                return employee;
            }

            return null;
        }

        private static Employee CreateEmployeeFromRow(DataRow row)
        {
            string firstName;
            if (row.IsNull("first_name"))
            {
                return null;
            }
            firstName = row["first_name"].ToString();

            string lastName;
            if (row.IsNull("last_name"))
            {
                return null;
            }
            lastName = row["last_name"].ToString();

            string suite = "";
            if (!row.IsNull("suite_number"))
            {
                suite = row["suite_number"].ToString();
            }
            
            string street = "";
            if (!row.IsNull("street_number"))
            {
                street = row["street_number"].ToString();
            }

            string house = "";
            if (!row.IsNull("house_number"))
            {
                house = row["house_number"].ToString();
            }

            string city = "";
            if (!row.IsNull("city"))
            {
                city = row["city"].ToString();
            }

            string province = "";
            if (!row.IsNull("province"))
            {
                province = row["province"].ToString();
            }

            string postalCode = "";
            if (!row.IsNull("postalcode"))
            {
                postalCode = row["postalcode"].ToString();
            }
            
            string phone = "";
            if (!row.IsNull("phone_number"))
            {
                phone = row["phone_number"].ToString();
            }
            
            Employee.Position position;
            if (row.IsNull("position"))
            {
                return null;
            }
            position = Employee.Position.Employee;
            if (row["position"].ToString() == "manager")
            {
                position = Employee.Position.Manager;
            }
            
            float wage;
            if (row.IsNull("wage"))
            {
                return null;
            }
            wage = float.Parse(row["wage"].ToString(), CultureInfo.InvariantCulture.NumberFormat);

            DateTime startDate;
            if (row.IsNull("start"))
            {
                return null;
            }
            startDate = (DateTime)row["start"];

            string sin = "";
            if (row.IsNull("social_insurance_num"))
            {
                sin = row["social_insurance_num"].ToString();
            }

            UserName name = new UserName(firstName, lastName);
            Address address = new Address(suite, street, house, city, province, postalCode);
            ContactInformation contactInfo = new ContactInformation("", phone);
            Employee employee = new Employee(name, address, contactInfo, wage, startDate, sin, position);
            employee.Id = (int)row["eid"];

            return employee;
        }

        private static Customer CreateCustomerFromRow(DataRow row)
        {
            string firstName;
            if (row.IsNull("first_name"))
            {
                return null;
            }
            firstName = row["first_name"].ToString();

            string lastName;
            if (row.IsNull("last_name"))
            {
                return null;
            }
            lastName = row["last_name"].ToString();

            string suite = "";
            if (!row.IsNull("suite_number"))
            {
                suite = row["suite_number"].ToString();
            }

            string street = "";
            if (!row.IsNull("street_number"))
            {
                street = row["street_number"].ToString();
            }

            string house = "";
            if (!row.IsNull("house_number"))
            {
                house = row["house_number"].ToString();
            }

            string city = "";
            if (!row.IsNull("city"))
            {
                city = row["city"].ToString();
            }

            string province = "";
            if (!row.IsNull("province"))
            {
                province = row["province"].ToString();
            }

            string postalCode = "";
            if (!row.IsNull("postalcode"))
            {
                postalCode = row["postalcode"].ToString();
            }

            string email = "";
            if (!row.IsNull("email"))
            {
                email = row["email"].ToString();
            }

            string phone = "";
            if (!row.IsNull("phone_number"))
            {
                phone = row["phone_number"].ToString();
            }

            DateTime creationDate;
            if (row.IsNull("creation_date"))
            {
                return null;
            }
            creationDate = (DateTime)row["creation_date"];

            string creditCard = "";
            if (!row.IsNull("credit_card"))
            {
                creditCard = row["credit_card"].ToString();
            }

            Customer.AccountType account = Customer.AccountType.Limited;
            switch (row["account_type"].ToString())
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
                    return null;
            }

            UserName name = new UserName(firstName, lastName);
            Address address = new Address(suite, street, house, city, province, postalCode);

            ContactInformation newContact = new ContactInformation(email, phone);
            Customer customer = new Customer(name, address, newContact, account);
            customer.CreationDate = creationDate;
            customer.CreditCard = creditCard;
            customer.Id = (int)row["cid"];
            customer.Rating = (int)row["rating"];

            return customer;
        }

        public static Movie CreateMovieFromRow(DataRow row)
        {
            string name;
            if (row.IsNull("name"))
            {
                return null;
            }
            name = row["name"].ToString();

            int mid;
            if (row.IsNull("mid"))
            {
                return null;
            }
            mid = (int)row["mid"];

            string genre = "";
            if (!row.IsNull("genre"))
            {
                genre = row["genre"].ToString();
            }

            float fees;
            if (row.IsNull("fees"))
            {
                return null;
            }
            fees = float.Parse(row["fees"].ToString());

            int numCopies;
            if (row.IsNull("num_copies"))
            {
                return null;
            }
            numCopies = (int)row["num_copies"];

            int available;
            if (row.IsNull("copies_available"))
            {
                return null;
            }
            available = (int)row["copies_available"];

            int rating = 0;
            if (!row.IsNull("rating"))
            {
                rating = (int)row["rating"];
            }

            return new Movie(name, genre, fees, numCopies, available, rating)
            {
                Id = mid
            };
        }

        public static string HashPassword(string password)
        {
            SHA1Managed sha1 = new SHA1Managed();
            byte[] hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(password));

            return Convert.ToBase64String(hash);
        }
    }
}