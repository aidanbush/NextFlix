using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{

    
    public partial class EmployeeAddEdit : Form
    {
        Employee employee;
        ManagerForm parent;
        FormInputHandler inputHandler;

        public EmployeeAddEdit(Employee selectedEmployee, ManagerForm form)
        {
            inputHandler = new FormInputHandler();
            parent = form;

            InitializeComponent();
            if (selectedEmployee == null)
            {
                return;
            }
            AddUserButton.Text = "Edit";
            employee = selectedEmployee;
            FillTextBoxes();


        }
        
        private void FillTextBoxes()
        {
            FirstNameBox.Text = employee.Name.FirstName;
            LastNameBox.Text = employee.Name.LastName;
            SuiteBox.Text = employee.Address.SuiteNumber;
            StreetBox.Text = employee.Address.StreetNumber;
            ProvinceBox.Text = employee.Address.Province;
            PostalBox.Text = employee.Address.PostalCode;
            CityBox.Text = employee.Address.City;
            HouseBox.Text = employee.Address.HouseNumber;
            PhoneBox.Text = employee.ContactInformation.PhoneNumber;
            SINBox.Text = employee.SIN;
            WageBox.Text = employee.Wage.ToString();
            PossitionBox.Text = employee.EmployeePosition.ToString();

 
        }

        private Employee CreateEmployee()
        {
            UserName user = new UserName(FirstNameBox.Text, LastNameBox.Text);
            Address userAddress = new Address(SuiteBox.Text, StreetBox.Text, HouseBox.Text, CityBox.Text, ProvinceBox.Text, PostalBox.Text);
            ContactInformation userInfo = new ContactInformation(null, PhoneBox.Text);
            Credentials credentials = new Credentials(UsernameTextBox.Text, PasswordTextBox.Text);

            Employee.Position position;
            if (PossitionBox.Text == "Manager")
            {
                position = Employee.Position.Manager;
            }
            else
            {
                position = Employee.Position.Employee;
            }

            Employee newEmployee = new Employee(user, userAddress, userInfo, float.Parse(WageBox.Text, CultureInfo.InvariantCulture.NumberFormat), DateTime.Now, SINBox.Text, position)
            {
                Credentials = credentials
            };
            return newEmployee;
        }

        private bool InsertUser()
        {
            if ((MessageBox.Show("Add new Employee with current information?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                try
                {
                    Employee newEmployee = CreateEmployee();
                    DBEnvironment.Add(newEmployee);
                    MessageBox.Show("Customer successfully added!");
                    return true;
                }
                catch (Exception Ex)
                {
                    return false;
                }
            }
                return false;
        }

        private bool EditUser()
        {
            if ((MessageBox.Show("Edit new Employee with current information?", "Confirm",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                try
                {

                    Employee updatedEmployee = CreateEmployee();
                    updatedEmployee.Id = employee.Id;
                    DBEnvironment.Edit(updatedEmployee);
                    MessageBox.Show("Customer successfully Edited!");
                    return true;
                }
                catch (Exception Ex)
                {
                    return false;
                }
            }
            return false;


        }
        
        private void EmployeeAddEdit_Load(object sender, EventArgs e)
        {

        }
        
        private bool checkFormInputs()
        {
            if (!inputHandler.checkNames(FirstNameBox.Text))
                return false;

            if (!inputHandler.checkNames(LastNameBox.Text))
                return false;

            try {
                PossitionBox.SelectedItem.ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show("Need to select a possition");
                return false;
            }

            if (!inputHandler.checkSIN(SINBox.Text))
                return false;

            try
            {
                ContactInformation userInfo = new ContactInformation(null, PhoneBox.Text);
                UserName user = new UserName(FirstNameBox.Text, LastNameBox.Text);
                Address userAddress = new Address(SuiteBox.Text, StreetBox.Text, HouseBox.Text, CityBox.Text, ProvinceBox.Text, PostalBox.Text);
                Employee newEmployee = new Employee(user, userAddress, userInfo, float.Parse(WageBox.Text, CultureInfo.InvariantCulture.NumberFormat), DateTime.Now, SINBox.Text, Employee.Position.Employee);
            }
            catch (Exception ex)
            {
                inputHandler.HandleException(ex);
                return false;
            }
            
            return true;
        }

        private bool ValidUsernamePassword()
        {
            if (UsernameTextBox.Text == "" || PasswordTextBox.Text == "")
                return false;

            if (!DBEnvironment.EmployeeUsernameAvailablility(UsernameTextBox.Text))
                return false;

            return true;
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            if (!checkFormInputs())
            {
                if (employee == null)
                    Debug.Print("Couldn't add employee");
                else
                    Debug.Print("Couldn't Edit employee");
                return;
            }

            if (employee == null)
            {
                if (!ValidUsernamePassword())
                    return;

                if (InsertUser())
                    parent.FillTable();
            }
            else
            {
                if (EditUser())
                    parent.FillTable();
            }

            this.Close();

        }

        private void CancelButton_Click_1(object sender, EventArgs e)
        {
            Debug.Print("cancelBtn");
            this.Close();
        }
    }
}
