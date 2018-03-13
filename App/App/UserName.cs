using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class UserName
    {
        private String firstName;
        private String lastName;

        public UserName(String fName, String lName)
        {
            FirstName = fName;
            LastName = lName;
        }

        /* Getters and Setters */
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }

        /* function Overrides */
        public override string ToString()
        {
            return FirstName + ", " + LastName;
        }
    }
}
