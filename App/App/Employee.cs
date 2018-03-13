using System;
using System.Data.SqlClient;

namespace App
{
    public class Employee : Person, IQuery
    {
        public enum Position {Employee, Manager};
        private Position position;
        private float wage;
        private DateTime startDate;
        private string sin;
        
        public Employee(UserName newName, Address newAddress, float newWage, DateTime newStart, string newSIN, Position newPosition)
        {
            Address = newAddress;
            Name =newName;
            EmployeePosition = newPosition;
            Wage = newWage;
            StartDate = newStart;
            SIN = newSIN;
        }

        /* Getters and Setters */
        public Position EmployeePosition { get => position; set => position = value; }
        public float Wage { get => wage; set => wage = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public string SIN { get => sin; set => sin = value; }
        
        public bool Add(SqlConnection con)
        {
            throw new NotImplementedException();
        }

        public bool Edit(SqlConnection con)
        {
            throw new NotImplementedException();
        }

        public bool Delete(SqlConnection con)
        {
            throw new NotImplementedException();
        }
    }
}