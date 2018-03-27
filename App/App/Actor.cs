using System.Data.SqlClient;
using System.Diagnostics;

namespace App
{
    public class Actor: IQuery
    {

        private UserName name;
        private string sex;
        private string dateOfBirth;
        //Id is set to -1 if adding aka it doesn't exist yet
        private int Id;
        
        public Actor(UserName name, string sex, string dateOfBirth, int id)
        {
            this.Sex = sex;
            this.Name = name;
            this.DateOfBirth = dateOfBirth;
            this.Id = id;
        }

        public UserName Name { get => name; set => name = value; }
        public string Sex { get => sex; set => sex = value; }
        public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }

        public bool Add(SqlConnection con)
        {
            Debug.Print("Adding Actor");
            //throw new System.NotImplementedException();
            return true;
        }

        public bool Delete(SqlConnection con)
        {
            Debug.Print("Deleting");
            throw new System.NotImplementedException();
        }

        public bool Edit(SqlConnection con)
        {
            Debug.Print("Edit");
            throw new System.NotImplementedException();
        }
    }
}