using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class AddToQueue : IQuery
    {
        private Movie movie;
        private Customer user;
        private DateTime creationDate;
        public AddToQueue(Movie selectedMovie, Customer currentUser)
        {
            movie = selectedMovie;
            user = currentUser;
            creationDate = DateTime.Now;
        }
        public bool MovieInQueue()
        {
            BindingList<Movie> userQueue;
            userQueue = DBEnvironment.RetrieveCustomerQueue(user);

            foreach(Movie queueMovie in userQueue)
            {
                if(queueMovie.Id == movie.Id)
                {
                    return true;
                }
            }
            return false;
        }
        public DateTime CreationDate { get => creationDate; set => creationDate = value; }
        public bool Add(SqlConnection con)
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
        public bool insertQueue(String queryString, SqlConnection con)
        {
            con.Open();
            using (SqlCommand command = new SqlCommand(queryString, con))
            {
                try
                {
                    command.Parameters.AddWithValue("@cid", this.user.Id);
                    command.Parameters.AddWithValue("@mid", this.movie.Id);
                    command.Parameters.AddWithValue("@creation_date", this.creationDate);
                    int err = command.ExecuteNonQuery();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.ToString());
                    con.Close();
                    return false;
                }
                con.Close();
                Console.WriteLine("Queue insertion successful");
                return true;
            }

        }
        bool IQuery.AddToQueue(SqlConnection con)
        {
            String q = "insert into queue(cid, mid, date_added)" +
               "values (@cid, @mid, @creation_date)";
            if(insertQueue(q, con))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
