using System.Data.SqlClient;
using System.Diagnostics;
using System.Data.SqlClient;
using System;

namespace App
{
    internal class Movie : IQuery
    {
        private string name;
        private string genre;
        private float fees;
        private int num_copies;
        private int copies_available;
        private int rating;

        public string Name { get => name; set => name = value; }
        public string Genre { get => genre; set => genre = value; }
        public float Fees { get => fees; set => fees = value; }
        public int Num_copies { get => num_copies; set => num_copies = value; }
        public int Copies_available { get => copies_available; set => copies_available = value; }
        public int Rating { get => rating; set => rating = value; }

        public Movie(string name, string genre, float fees, int numOfCopies, int copiesAvailable, int rating)
        {
            Name = name;
            Genre = genre;
            Fees = fees;
            Num_copies = numOfCopies;
            Copies_available = numOfCopies;
            Rating = rating;
        }
        public bool Add(SqlConnection con)
        {

            con.Open();
            String q = "insert into movie(name, genre, fees, num_copies, copies_available)" +
               "values (@name, @genre, @fees, @num_copies, @copies_available)";

            using (SqlCommand command = new SqlCommand(q, con))
            {
                try
                {
                    command.Parameters.AddWithValue("@name", Name);
                    command.Parameters.AddWithValue("@genre", Genre);
                    command.Parameters.AddWithValue("@fees", Fees);
                    command.Parameters.AddWithValue("@num_copies", Num_copies);
                    command.Parameters.AddWithValue("@copies_available", Copies_available);
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

        public bool Delete(SqlConnection con)
        {
            throw new System.NotImplementedException();
        }

        public bool Edit(SqlConnection con)
        {
            throw new System.NotImplementedException();
        }
    }
}