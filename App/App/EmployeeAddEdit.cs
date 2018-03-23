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

        }

        private void EmployeeAddEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
