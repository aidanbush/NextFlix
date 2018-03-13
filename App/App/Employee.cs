using System;

namespace App
{
    public class Employee : Person
    {
        public enum Position {Employee, Manager};
        private Position position;
        private float wage;
        private DateTime startDate;
        private string SIN;

        public float Wage { get => wage; set => wage = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public string SIN1 { get => SIN; set => SIN = value; }
        public Position EmployeePosition { get => position; set => position = value; }

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
    }
}