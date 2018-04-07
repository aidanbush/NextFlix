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
using System.Data.SqlTypes;
namespace App
{
    internal static class DBEnvironment
    {
        private static SqlConnection con;
        private static SqlDataAdapter sda;
        private static BindingList<Customer> customers;
        private static BindingList<Employee> employees;
        private static BindingList<Movie> movies;
        private static BindingList<Actor> actors;


        public static BindingList<Customer> GetCustomers()
        {
            return customers;
        }

        public static void SetCustomers()
        {
            customers = RetrieveCustomers();
        }

        public static void SetActors()
        {
            actors = RetreiveActors();
            
        }
        public static BindingList<Actor> GetActors()
        {
            return actors;

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

        public static bool MovieRatingQuery(String query, Movie movie, Customer user, int rating)
        {
            con.Open();
            using (SqlCommand command = new SqlCommand(query, con))
            {
                try
                {
                    command.Parameters.AddWithValue("@mid", movie.Id);
                    command.Parameters.AddWithValue("@cid", user.Id);
                    command.Parameters.AddWithValue("@rating", rating);
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
        public static bool EditMovieRating(Movie movie, Customer user, int rating)
        {
            String q = "UPDATE movie_rating SET rating=@rating where mid=@mid and cid=@cid";
            return MovieRatingQuery(q, movie, user, rating);
        }

        public static bool AddMovieRating(Movie movie, Customer user, int rating)
        {
            String q = "insert into movie_rating (mid, cid, rating) values (@mid, @cid, @rating);";
            return MovieRatingQuery(q, movie, user, rating);
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


        private static BindingList<Movie> fetchMoviesFromTable(String query)
        {

            SqlDataAdapter adaptor = new SqlDataAdapter(query, con);
            BindingList<Movie> Movies = new BindingList<Movie>();
            DataTable table = new DataTable();
            adaptor.Fill(table);

            foreach (DataRow movie in table.Rows)
            {
                Movie MovieFromDatabase = CreateMovieFromRow(movie);
                Debug.Print(MovieFromDatabase.ToString());
                Movies.Add(MovieFromDatabase);
            }

            return Movies;
        }
        public static BindingList<Movie> GetCurrentlyRentedMoviesInThisMonth(Customer user)
        {
    
            DateTime now = DateTime.Now;
            now = now.AddDays(-DateTime.Now.Day);
 
            String qString = "SELECT * FROM movie where" +
                " mid in (SELECT mid FROM [order] WHERE cid=" + user.Id + 
                " and eid IS NOT NULL and order_placed BETWEEN '"+ now.ToString("yyyy-MM-dd HH:mm:ss.fff")  +"' AND '"+ DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "')";

            Debug.Print(qString);
            return fetchMoviesFromTable(qString);
        }
        public static BindingList<Movie> GetCurrentlyRentedMovies(Customer user)
        {

            String qString = "SELECT * FROM movie where" +
                " mid in (SELECT mid FROM [order] WHERE cid=" + user.Id + " and eid IS NOT NULL and date_returned IS NULL)";

            return fetchMoviesFromTable(qString);

        }

        public static BindingList<Actor> GetActors(Movie movie)
        {
            String qString = "SELECT * FROM starred WHERE mid=" + movie.Id;
            SqlDataAdapter adaptor = new SqlDataAdapter(qString, con);
            BindingList<Actor> Actors = new BindingList<Actor>();
            DataTable table = new DataTable();
            adaptor.Fill(table);

            foreach (DataRow aid in table.Rows)
            {
                String actorFetch = "SELECT * from actor WHERE aid=" + aid["aid"].ToString();
                SqlDataAdapter actorAdaptor = new SqlDataAdapter(actorFetch, con);
                DataTable actorTable = new DataTable();
                actorAdaptor.Fill(actorTable);
                foreach (DataRow actor in actorTable.Rows)
                {

                    UserName name = new UserName(actor["first_name"].ToString(), actor["last_name"].ToString());
                    string sex = actor["sex"].ToString();
                    DateTime dateOfBirth = (DateTime)actor["dob"];
                    string age = actor["age"].ToString();
                    string rating = actor["rating"].ToString();
                    string Id = actor["aid"].ToString();
                    Actor act = new Actor(name, sex, dateOfBirth, Id, age, rating);
                    Actors.Add(act);
                }
            }

            return Actors;

        }
        public static BindingList<Customer> RetrieveCustomers()
        {
            BindingList<Customer> customers = new BindingList<Customer>();

            string qString = "SELECT * FROM customer";
            SqlDataAdapter adaptor = new SqlDataAdapter(qString, con);

            DataTable customerTable = new DataTable();
            adaptor.Fill(customerTable);

            foreach (DataRow customerRow in customerTable.Rows) {
                Customer customer = CreateCustomerFromRow(customerRow);
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
                Employee employee = CreateEmployeeFromRow(employeeRow);
                employeeList.Add(employee);
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
                Movie movie = CreateMovieFromRow(movieRow);
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

        public static BindingList<Actor> RetreiveActors()
        {

            string qString = "SELECT * FROM [actor]";
            SqlDataAdapter adapter = new SqlDataAdapter(qString, con);
            DataTable actorTable = new DataTable();
            adapter.Fill(actorTable);
            BindingList<Actor> actors = new BindingList<Actor>();
            
            foreach (DataRow actor in actorTable.Rows)
            {
                UserName name = new UserName(actor["first_name"].ToString(), actor["last_name"].ToString());
                string sex = actor["sex"].ToString();
                DateTime dateOfBirth = (DateTime)actor["dob"];
                string age = actor["age"].ToString();
                string rating = actor["rating"].ToString();
                string Id = actor["aid"].ToString();
                Actor act = new Actor(name, sex, dateOfBirth, Id, age, rating);
                actors.Add(act);
            }

            return actors;

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

        public static bool CustomerUsernameAvailablility(string username)
        {
            // use top so it breaks out early
            string qString = "SELECT TOP 1 * FROM customer WHERE username LIKE @username";

            SqlDataAdapter adapter = new SqlDataAdapter(qString, con);
            adapter.SelectCommand.Parameters.AddWithValue("@username", username);

            DataTable table = new DataTable();
            adapter.Fill(table);

            return table.Rows.Count == 0;
        }

        public static bool EmployeeUsernameAvailablility(string username)
        {
            // use top so it breaks out early
            string qString = "SELECT TOP 1 * FROM employee WHERE username LIKE @username";

            SqlDataAdapter adapter = new SqlDataAdapter(qString, con);
            adapter.SelectCommand.Parameters.AddWithValue("@username", username);

            DataTable table = new DataTable();
            adapter.Fill(table);

            return table.Rows.Count == 0;
        }

        public static Customer ValidateCustomer(string username, string passhash)
        {
            string qString = "SELECT * FROM customer WHERE username LIKE @username AND passhash LIKE @passhash AND account_type NOT LIKE 'Disabled'";
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
            string qString = "SELECT * FROM employee WHERE username LIKE @username AND passhash LIKE @passhash";
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
            string qString = "SELECT * FROM employee WHERE username LIKE @username AND passhash LIKE @passhash AND position = 'manager'";
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
            Credentials credentials = new Credentials(row["username"].ToString(), row["passhash"].ToString());
            Employee employee = new Employee(name, address, contactInfo, wage, startDate, sin, position)
            {
                Id = (int)row["eid"],
                Credentials = credentials
            };
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

            Credentials credentials = new Credentials(row["username"].ToString(), row["passhash"].ToString());

            Customer customer = new Customer(name, address, newContact, account)
            {
                CreationDate = creationDate,
                CreditCard = creditCard,
                Id = (int)row["cid"],
                Rating = (int)row["rating"],
                Credentials = credentials
            };

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