using System;
using System.Data.SqlClient;
using System.Diagnostics;

namespace App
{
    public class Actor: IQuery
    {

        private UserName name;
        private string sex;
        private DateTime dateOfBirth;
        private string id;
        private string rating;
        private string age;
        
        public Actor(UserName name, string sex, DateTime dateOfBirth, string id, string age, string rating)
        {
            this.Sex = sex;
            this.Name = name;
            this.DateOfBirth = dateOfBirth;
            this.Id = id;
            this.Rating = rating;
            this.Age = age;
        }

        public UserName Name { get => name; set => name = value; }
        public string Sex { get => sex; set => sex = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Rating { get => rating; set => rating = value; }
        public string Age { get => age; set => age = value; }
        public string Id { get => id; set => id = value; }
        
        public bool AddEdit(string q, SqlConnection con, int id)
        {
            con.Open();
            using (SqlCommand command = new SqlCommand(q, con))
            {
                try
                {
                    command.Parameters.AddWithValue("@first_name", this.Name.FirstName);
                    command.Parameters.AddWithValue("@last_name", this.Name.LastName);
                    command.Parameters.AddWithValue("@dob", this.DateOfBirth);
                    command.Parameters.AddWithValue("@sex", this.Sex);
                    if (id > -1)
                    {
                        command.Parameters.AddWithValue("@aid", id);
                    }

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
        
        public bool Add(SqlConnection con)
        {
            String q = "insert into actor(first_name, last_name, dob, sex)" +
                "values (@first_name, @last_name, @dob, @sex)";
            return AddEdit(q, con, -1);

        }

        public bool Delete(SqlConnection con)
        {
            String q = "DELETE FROM actor WHERE aid=@aid";

            con.Open();
            using (SqlCommand command = new SqlCommand(q, con))
            {
                try
                {
                    command.Parameters.AddWithValue("@aid", int.Parse(this.Id));
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
            String q = "UPDATE actor SET first_name=@first_name, " +
                  "last_name=@last_name, " +
                  "dob=@dob, " +
                  "sex=@sex " + 
                  "WHERE aid=@aid";
            int result;
            Int32.TryParse(this.Id, out result);
            return AddEdit(q, con, result);
        }

        public bool AddToQueue(SqlConnection con)
        {
            throw new NotImplementedException();
        }
    }
}