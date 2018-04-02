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
            String q = "insert into starred(mid, aid)" +
         "values (@mid, @aid)";
            foreach (Actor actor in addedActors)
            {
                if (!query(actor, movie, q, con))
                    return false;
            }
            return true;
        }

        public bool Delete(SqlConnection con)
        {
            
            String q = "Delete FROM starred WHERE mid=@mid AND aid=@aid";
            foreach (Actor actor in deletedActors)
            {
                if (!query(actor, movie, q, con))
                    return false;
            }
            return true;
        }

        public bool Edit(SqlConnection con)
        {
            if (!Add(con))
               return false;
            if (!Delete(con))
                return false;
            return true;
        }


        private bool query(Actor actor, Movie movie, String q, SqlConnection con)
        {
            con.Open();
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
                    Debug.Print(e.ToString());
                    con.Close();
                    return false;
                }

            }
            con.Close();
            return true;
        }
    }
    
}