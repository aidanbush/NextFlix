using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class Order : IQuery
    {
        private int id;
        private int movieID;
        private int customerID;
        private int employeeID;
        private DateTime placedDate;


        public Order(int newMovieID, int newcustomerID, int newEmployeeID)
        {
            movieID = newMovieID;
            customerID = newcustomerID;
            employeeID = newEmployeeID;
            placedDate = DateTime.Now;
        }

        /* getters and setters */
        public int Id { get => id; set => id = value; }
        public int MovieID { get => movieID; set => movieID = value; }
        public int CustomerID { get => customerID; set => customerID = value; }
        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public DateTime PlacedDate { get => placedDate; set => placedDate = value; }

        /* sql functions */
        public bool Add(SqlConnection con)
        {
            string query = "insert into [order](cid, mid, eid, order_placed)" +
                "values (@cid, @mid, @eid, @date_added)";

            con.Open();
            using (SqlCommand command = new SqlCommand(query, con))
            try
            {
                command.Parameters.AddWithValue("@cid", this.customerID);
                command.Parameters.AddWithValue("@mid", this.movieID);
                command.Parameters.AddWithValue("@eid", this.employeeID);
                command.Parameters.AddWithValue("@date_added", this.placedDate);

                int err = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                con.Close();
                return false;
            }
            con.Close();
            return true;
            
        }

        public bool AddToQueue(SqlConnection con)
        {
            throw new NotImplementedException();
        }

        public bool Delete(SqlConnection con)
        {
            throw new NotImplementedException();
        }

        public bool Edit(SqlConnection con)
        {
            throw new NotImplementedException();
        }
    }
}
