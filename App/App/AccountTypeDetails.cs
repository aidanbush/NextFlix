using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{

    class AccountTypeDetails
    {
        public enum AccountType { Disabled, Limited, Bronze, Silver, Gold };
        string accountType;
        private int price;
        private int moviesAllowed;
        private int rentalsAllowed;

        public AccountTypeDetails(string type)
        {
            accountType = type;

            switch (type)
            {
                case ("limited"):
                    price = 10;
                    moviesAllowed = 1;
                    rentalsAllowed = 2;
                    break;
                case ("bronze"):
                    price = 15;
                    moviesAllowed = 1;
                    rentalsAllowed = 0;
                    break;
                case ("silver"):
                    price = 20;
                    moviesAllowed = 2;
                    rentalsAllowed = 0;
                    break;
                case ("gold"):
                    price = 25;
                    moviesAllowed = 3;
                    rentalsAllowed = 0;
                    break;
            }
        }
        public string GetPrice()
        {
            return price.ToString();
        }

        public string GetMoviesAllowed()
        {
            return moviesAllowed.ToString();
        }
        public string GetRentalsAllowed()
        {
            if (rentalsAllowed == 0)
            {
                return "Unlimited";
            }
            else
            {
                return rentalsAllowed.ToString();
            }
        }
        public string GetAccountType()
        {
            return accountType;
        }
    }
}
