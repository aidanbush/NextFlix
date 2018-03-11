using System;

namespace App
{
    public class Employee : Person
    {
        private string position;
        private float wage;
        private DateTime startDate;
        private string SIN;

        public Employee(string newPosition, float newWage, DateTime newStart, string newSIN)
        {
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

        public string GetPosition()
        {
            return position;
        }

        public void SetPosition(string value)
        {
            position = value;
        }
    }
}