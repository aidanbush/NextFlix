using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security;
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
            Customer customer = ValidateCustomer();
            if (customer != null)
            {
                new CustomerForm(this, customer).Show();
                this.Hide();
                ClearCredentials();
                return;
            }

            SetError("Invaid Username and Password");
        }

        private void EmployeeButtonClick(object sender, EventArgs e)
        {
            Employee employee = ValidateEmployee();
            if (employee != null)
            {
                new ManagerForm(this, employee).Show();
                this.Hide();
                ClearCredentials();
                return;
            }

            SetError("Invaid Username and Password");
        }

        private void ManagerButtonClick(object sender, EventArgs e)
        {
            Employee manager = ValidateManager();
            if (manager != null)
            {
                new ManagerForm(this, manager).Show();
                this.Hide();
                ClearCredentials();
                return;
            }

            SetError("Invaid Username and Password");
        }

        private Customer ValidateCustomer()
        {
            string name = NameTextBox.Text;
            string pass = PasswordTextBox.Text;
            Customer customer;

            if (name == "admin" && pass == "pass")
            {
                customer = DBEnvironment.ValidateCustomer(name, pass);
                return customer;
            }

            customer = DBEnvironment.ValidateCustomer(name, DBEnvironment.HashPassword(pass));

            return customer;
        }

        private Employee ValidateEmployee()
        {
            string name = NameTextBox.Text;
            string pass = PasswordTextBox.Text;
            Employee employee;
            
            if (name == "admin" && pass == "pass")
            {
                employee = DBEnvironment.ValidateEmployee(name, pass);
                return employee;
            }

            employee = DBEnvironment.ValidateEmployee(name, DBEnvironment.HashPassword(pass));
            
            return employee;
        }

        private Employee ValidateManager()
        {
            string name = NameTextBox.Text;
            string pass = PasswordTextBox.Text;
            Employee manager;
            
            if (name == "admin" && pass == "pass")
            {
                manager = DBEnvironment.ValidateManager(name, pass);
                return manager;
            }

            manager = DBEnvironment.ValidateManager(name, DBEnvironment.HashPassword(pass));

            return manager;
        }

        private void ClearCredentials()
        {
            NameTextBox.Text = "";
            PasswordTextBox.Text = "";
        }

        private void SetError(string msg)
        {
            ErrorLabel.Text = msg;
            ErrorLabel.Show();
        }
    }
}
