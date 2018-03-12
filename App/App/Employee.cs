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

        public Employee(UserName newName, Address newAddress, float newWage, DateTime newStart, string newSIN, Position newPosition)
        {
            SetAddress(newAddress);
            SetName(newName);
            SetPosition(newPosition);
            SetWage(newWage);
            SetStartDate(newStart);
            SetSIN(newSIN);
        }

        /* Getters and Setters */
        public string GetSIN()
        {
            return SIN;
        }

        public void SetSIN(string value)
        {
            SIN = value;
        }

        public DateTime GetStartDate()
        {
            return startDate;
        }

        public void SetStartDate(DateTime value)
        {
            startDate = value;
        }

        public float GetWage()
        {
            return wage;
        }

        public void SetWage(float value)
        {
            wage = value;
        }

        public Position GetPosition()
        {
            return position;
        }

        public void SetPosition(Position value)
        {
            position = value;
        }
    }
}