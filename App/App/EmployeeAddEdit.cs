using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public enum FormType { add, edit };

        public EmployeeAddEdit(Employee selectedEmployee, ManagerForm form)
        {
            
            parent = form;
            InitializeComponent();
            if (selectedEmployee == null)
            {
                return;
            }
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
        private void EditUser()
        {
            Employee updatedEmployee = employee;
            if (employee.Name.FirstName != FirstNameBox.Text)
            {
                updatedEmployee.Name.FirstName = FirstNameBox.Text;
            }
            if (employee.Name.LastName != LastNameBox.Text)
            {
                updatedEmployee.Name.LastName = LastNameBox.Text;
            }
            if (employee.Address.City != CityBox.Text)
            {
                updatedEmployee.Address.City = CityBox.Text;
            }
            if (employee.Address.HouseNumber != HouseBox.Text)
            {
                updatedEmployee.Address.HouseNumber = HouseBox.Text;
            }
            if (employee.Address.PostalCode != PostalBox.Text)
            {
                updatedEmployee.Address.PostalCode = PostalBox.Text;
            }
            if (employee.Address.Province != ProvinceBox.Text)
            {
                updatedEmployee.Address.Province = ProvinceBox.Text;
            }
            if (employee.Address.StreetNumber != StreetBox.Text)
            {
                updatedEmployee.Address.StreetNumber = StreetBox.Text;
            }
            if (employee.Address.SuiteNumber != SuiteBox.Text)
            {
                updatedEmployee.Address.SuiteNumber = SuiteBox.Text;
            }
            if (employee.ContactInformation.PhoneNumber != PhoneBox.Text)
            {
                updatedEmployee.ContactInformation.PhoneNumber = PhoneBox.Text;
            }
            if (SINBox.Text != employee.SIN)
            {
                updatedEmployee.SIN = SINBox.Text;
            }
            if (WageBox.Text != employee.Wage.ToString())
            {
                updatedEmployee.Wage = float.Parse(WageBox.Text, CultureInfo.InvariantCulture.NumberFormat);
            }
            if (PossitionBox.Text == Employee.Position.Employee.ToString())
            {
                updatedEmployee.EmployeePosition = Employee.Position.Employee;
            }
            else if(PossitionBox.Text == Employee.Position.Manager.ToString())
            {
                updatedEmployee.EmployeePosition = Employee.Position.Manager;
            }

            DBEnvironment.Edit(updatedEmployee);
            MessageBox.Show("Employee edit complete!");
        }
  
        private void EditUserButton_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Edit Employee with current information?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                EditUser();
                parent.FillTable();
                this.Close();
            }


        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Cancel Customer Entry? (Information will not be saved)", "Cancel",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                this.Close();
            }
        }

        private void EmployeeAddEdit_Load(object sender, EventArgs e)
        {

        }

        //exception handling
        private bool NameBoxesValid()
        {
            if (FirstNameBox.Text == "" && LastNameBox.Text == "")
            {

                MessageBox.Show("The customer's first and last name cannot be blank");
                return false;
            }
            else if (FirstNameBox.Text == "")
            {

                MessageBox.Show("The customer's first name cannot be blank.");
                return false;
            }
            else if (LastNameBox.Text == "")
            {

                MessageBox.Show("The customer's last name cannot be blank");
                return false;
            }

            else
            {
                return true;
            }
        }

        private void HandleException(Exception Ex)
        {
            if (Ex is AccountTypeException)
            {
                MessageBox.Show("Choose an account type.");
                return;
            }
            if (Ex is PostalCodeException)
            {
                MessageBox.Show("Invalid postal code.");
                return;
            }
            else if (Ex is PhoneNumberException)
            {
                MessageBox.Show("Invalid Phone Number.");
                return;
            }
        }
        //

        private String CheckBlankBoxes(TextBox box)
        {
            String outString;
            switch (box.Text)
            {
                case ("eg t1t1t1"):
                    outString = "";
                    break;
                case ("eg username@email.com"):
                    outString = "";
                    break;
                default:
                    outString = box.Text;
                    break;
            }
            return outString;
        }
        private Employee CreateEmployee()
        {
            String postal = CheckBlankBoxes(PostalBox);
            UserName user = new UserName(FirstNameBox.Text, LastNameBox.Text);
            Address userAddress = new Address(SuiteBox.Text, StreetBox.Text, HouseBox.Text, CityBox.Text, ProvinceBox.Text, postal);
            ContactInformation userInfo = new ContactInformation(null, PhoneBox.Text);
            Employee newEmployee = new Employee(user, userAddress, userInfo, 1, DateTime.Now, "1", Employee.Position.Employee);
            return newEmployee;
        }
        private bool InsertUser()
        {
            if ((MessageBox.Show("Add new Customer with current information?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                try
                {
                    Employee newEmployee = CreateEmployee();
                    DBEnvironment.Add(newEmployee);
                    MessageBox.Show("Customer successfully added!");
                    parent.Refresh();

                    return true;
                }
                catch (Exception Ex)
                {
                    HandleException(Ex);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        private void AddUserButton_Click(object sender, EventArgs e)
        {
            if (NameBoxesValid() == true)
            {
                if (InsertUser() == true)
                {
                    parent.FillTable();
                    this.Close();
                }
            }
        }
        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            this.PostalBox.Enter += new EventHandler(PostalBox_Enter);
            this.PostalBox.Leave += new EventHandler(PostalBox_Leave);
            defaultSetText();

        }
        protected void defaultSetText()
        {

            this.PostalBox.Text = "eg t1t1t1";
            PostalBox.ForeColor = Color.Gray;
        }
        private void PostalBox_Enter(object sender, EventArgs e)
        {
            if (PostalBox.ForeColor == Color.Black)
                return;
            PostalBox.Text = "";
            PostalBox.ForeColor = Color.Black;
        }
        private void PostalBox_Leave(object sender, EventArgs e)
        {
            if (PostalBox.Text.Trim() == "")
                defaultSetText();
        }
        
    }
}
