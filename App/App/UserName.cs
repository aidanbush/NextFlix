using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class UserName
    {
        private String firstName;
        private String lastName;

        public UserName(String fName, String lName)
        {
            firstName = fName;
            lastName = lName;
        }

        public String GetFirstName()
        {
            return firstName;
        }

        public String GetLastName()
        {
            return lastName;
        }
    }
}
