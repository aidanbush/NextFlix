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
        private DateTime dateReturned;


        public Order(int newMovieID, int newcustomerID)
        {
            MovieID = newMovieID;
            CustomerID = newcustomerID;
        }

        /* getters and setters */
        public int Id { get => id; set => id = value; }
        public int MovieID { get => movieID; set => movieID = value; }
        public int CustomerID { get => customerID; set => customerID = value; }
        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public DateTime PlacedDate { get => placedDate; set => placedDate = value; }
        public DateTime DateReturned { get => dateReturned; set => dateReturned = value; }

        /* sql functions */
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
    }
}
