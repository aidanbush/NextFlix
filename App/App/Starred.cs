using System;
using System.Data.SqlClient;
using System.Diagnostics;

namespace App
{
    internal class Starred : IQuery
    {
        Actor[] addedActors;
        Actor[] deletedActors;
        Movie movie;
   
        public Starred(Actor[] addedActors, Actor[] deletedActors, Movie movie)
        {
            this.addedActors = addedActors;
            this.deletedActors = deletedActors;
            this.movie = movie;
        }
        public bool Add(SqlConnection con)
        {
            con.Open();
            String q = "insert into starred(mid, aid)" +
         "values (@mid, @aid)";

            foreach (Actor actor in addedActors)
            {
                query(actor, movie, q, con);
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
            con.Open();
            String q = "Delete FROM starred WHERE mid=@mid AND aid=@aid";
            foreach (Actor actor in deletedActors)
            {
                query(actor, movie, q, con);
            }
            con.Close();
            return true;
        }

        public bool Edit(SqlConnection con)
        {
            Add(con);
            Delete(con);
            return true;
        }


        private bool query(Actor actor, Movie movie, String q, SqlConnection con)
        {

            using (SqlCommand command = new SqlCommand(q, con))
            {
                try
                {
                    if (movie.Id == -1)
                        movie.fetchId(con);
                
                    command.Parameters.AddWithValue("@mid", movie.Id);
                    command.Parameters.AddWithValue("@aid", actor.Id);
                    int err = command.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    Debug.Print("Couldn't add " + actor.Id);
                    return false;
                }

            }
            return true;
        }
    }
    
}