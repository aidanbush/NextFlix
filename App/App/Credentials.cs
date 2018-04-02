using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class Credentials
    {
        private string username;
        private string passHash;

        public string Username { get => username; }
        public string PassHash { get => passHash; }

        public Credentials(string newUsername, string password)
        {
            username = newUsername;
            passHash = DBEnvironment.HashPassword(password);
        }
    }
}
