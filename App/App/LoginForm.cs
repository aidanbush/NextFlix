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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void CustomerButtonClick(object sender, EventArgs e)
        {
            if (ValidateCustomer())
            {
                // switch view
            }
            // print error
            SetError("Invaid Username and Password");
        }

        private void EmployeeButtonClick(object sender, EventArgs e)
        {
            if (ValidateEmployee())
            {
                new ManagerForm(ManagerForm.EmploymentRole.employee).Show();
                this.Hide();
            }
            // print error
            SetError("Invaid Username and Password");
        }

        private void ManagerButtonClick(object sender, EventArgs e)
        {
            if (ValidateManager())
            {
                new ManagerForm(ManagerForm.EmploymentRole.manager).Show();
                this.Hide();
            }
            // print error
            SetError("Invaid Username and Password");
        }

        private bool ValidateCustomer()
        {
            string name = NameTextBox.Text;
            string pass = PasswordTextBox.Text;

            if (name == "admin" && pass == "pass")
            {
                return true;
            }

            return false;
        }

        private bool ValidateEmployee()
        {
            string name = NameTextBox.Text;
            string pass = PasswordTextBox.Text;
            if (name == "admin" && pass == "pass")
            {
                return true;
            }

            return false;
        }

        private bool ValidateManager()
        {
            string name = NameTextBox.Text;
            string pass = PasswordTextBox.Text;
            if (name == "admin" && pass == "pass")
            {
                return true;
            }

            return false;
        }

        private void SetError(string msg)
        {
            ErrorLabel.Text = msg;
            ErrorLabel.Show();
        }
    }
}
