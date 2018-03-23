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
            /*
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
            */
        }

        private Employee CreateEmployee()
        {
            UserName user = new UserName(FirstNameBox.Text, LastNameBox.Text);
            //UserName user = new UserName("firstname","asdfasdf");
            //Address userAddress = new Address(SuiteBox.Text, StreetBox.Text, HouseBox.Text, CityBox.Text, ProvinceBox.Text, PostalBox.Text);
            Address userAddress = new Address("asd", "asd", "asd", "asd", "AB", "r1r1r1");
            ContactInformation userInfo = new ContactInformation(null, PhoneBox.Text);
            //ContactInformation userInfo = new ContactInformation(null, "1231231234");
            //Employee newEmployee = new Employee(user, userAddress, userInfo, 1, DateTime.Now, "123123123", Employee.Position.Employee);
            Employee newEmployee = new Employee(user, userAddress, userInfo, 1, DateTime.Now, SINBox.Text, Employee.Position.Employee);
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
                    //TODO do some kind of handling here
                    return false;
                }
            }
                return false;
        }
        
        private void EmployeeAddEdit_Load(object sender, EventArgs e)
        {

        }



        private bool checkFormInputsGood()
        {
            if (!inputHandler.checkNames(FirstNameBox.Text))
                return false;
            if (!inputHandler.checkNames(LastNameBox.Text))
                return false;
            try { PossitionBox.SelectedItem.ToString(); }
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
        private void AddUserButton_Click(object sender, EventArgs e)
        {
            
            if (!checkFormInputsGood())
            {
                Debug.Print("Couldn't add employee");
                return;
            }
             if (InsertUser())
                 parent.FillTable();

             this.Close();

        }

        private void CancelButton_Click_1(object sender, EventArgs e)
        {
            Debug.Print("cancelBtn");
        }
    }
}
