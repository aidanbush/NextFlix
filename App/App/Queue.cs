using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    
    class Queue : IQuery
    {
        private int customerID;
        private int movieID;
        private DateTime creationDate;

        public Queue(int cid, int mid, DateTime date)
        {
            customerID = cid;
            movieID = mid;
            creationDate = date;
        }
        public int MovieID { get => movieID; set => movieID = value; }
        public int CustomerID { get => customerID; set => customerID = value; }
        public DateTime CreationDate { get => creationDate; set => creationDate = value; }

        public bool Add(SqlConnection con)
        {
            throw new NotImplementedException();
        }

        public bool AddToQueue(SqlConnection con)
        {
            throw new NotImplementedException();
        }

        public bool Delete(SqlConnection con)
        {
            con.Open();

            int cid = this.customerID;
            int mid = this.movieID;
            Console.WriteLine("USER " + cid.ToString());
            Console.WriteLine("MOVIE " + mid.ToString());
            //DateTime date = this.creationDate;
            string query = "DELETE FROM queue WHERE cid=@cid AND mid=@mid AND date_added= @date";
            try
            {
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@cid", this.customerID);
                    command.Parameters.AddWithValue("@mid", this.movieID);
                    command.Parameters.AddWithValue("@date", this.creationDate);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                con.Close();
                return false;
            }
            Console.WriteLine("DELETED");
            con.Close();
            return true;
        }

        public bool Edit(SqlConnection con)
        {
            throw new NotImplementedException();
        }
    }
}
