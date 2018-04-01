using System.Data.SqlClient;
using System.Diagnostics;
using System.Data.SqlClient;
using System;

namespace App
{
    public class Movie : IQuery
    {
        private string name;
        private string genre;
        private float fees;
        private int num_copies;
        private int copies_available;
        private int rating;
        private int id;

        public string Name { get => name; set => name = value; }
        public string Genre { get => genre; set => genre = value; }
        public float Fees { get => fees; set => fees = value; }
        public int Num_copies { get => num_copies; set => num_copies = value; }
        public int Copies_available { get => copies_available; set => copies_available = value; }
        public int Rating { get => rating; set => rating = value; }
        public int Id { get => id; set => id = value; }

        public Movie(string name, string genre, float fees, int numOfCopies, int copiesAvailable, int rating)
        {
            Name = name;
            Genre = genre;
            Fees = fees;
            Num_copies = numOfCopies;
            Copies_available = numOfCopies;
            Rating = rating;
        }

        public bool AddEdit(String queryString, SqlConnection con)
        {
            con.Open();
            using (SqlCommand command = new SqlCommand(queryString, con))
            {
                try
                {
                    command.Parameters.AddWithValue("@name", Name);
                    command.Parameters.AddWithValue("@genre", Genre);
                    command.Parameters.AddWithValue("@fees", Fees);
                    command.Parameters.AddWithValue("@num_copies", Num_copies);
                    command.Parameters.AddWithValue("@copies_available", Copies_available);
                   
                    command.Parameters.AddWithValue("@mid", this.Id);
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

        public bool Add(SqlConnection con)
        {

            String q = "insert into movie(name, genre, fees, num_copies, copies_available)" +
               "values (@name, @genre, @fees, @num_copies, @copies_available)";
            if (AddEdit(q, con))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool Delete(SqlConnection con)
        {

            String q = "DELETE FROM movie WHERE mid=@mid";

            con.Open();
            using (SqlCommand command = new SqlCommand(q, con))
            {
                try
                {
                    command.Parameters.AddWithValue("@mid", this.Id);
                    int err = command.ExecuteNonQuery();
                }

                catch (Exception e)
                {
                    con.Close();
                    Console.WriteLine("Database failed to delete record");
                    return false;
                }
            }
            con.Close();
            return true;

        }

        public bool Edit(SqlConnection con)
        {
            String q = "UPDATE movie SET Name=@Name, " +
                       "genre=@genre, " +
                       "fees=@fees, " +
                       "num_copies=@num_copies " +
                       "WHERE mid=@mid";
            
            if (AddEdit(q, con))
            {
                Console.WriteLine("Movie updated");
                return true;
            }
            else
            {
                Console.WriteLine("User could not be updated");
                return false;
            }
        }

        public bool AddToQueue(SqlConnection con)
        {
            throw new NotImplementedException();
        }
    }
}