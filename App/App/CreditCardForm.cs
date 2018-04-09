using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class CreditCardForm : Form
    {
        CustomerForm parentForm;
        Customer currentUser;
        public CreditCardForm(Customer user, CustomerForm parent)
        {
            parentForm = parent;
            currentUser = user;
            InitializeComponent();
        }
        private bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        private void CreditCardUpdateButton_Click(object sender, EventArgs e)
        {
            string number = CardNumberBox.Text;

            if(number == "")
            { 
                MessageBox.Show("Enter a number to update your credit card info.");
            }
            else if(!IsDigitsOnly(number))
            {
                MessageBox.Show("Credit card number must be all numbers.");
            }
            else
            {
                if (currentUser.EditCustomerCreditCardNumber(number))
                {
                    MessageBox.Show("SUCCESS");
                }
                else
                {
                    MessageBox.Show("NO SUCCESS");
                }
            }
        }
    }
}
