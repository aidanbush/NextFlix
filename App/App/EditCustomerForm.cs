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
    public partial class EditCustomerForm : Form
    {
        private Customer customer;
        private ManagerForm managerParent;
        private CustomerForm customerParent;
        private enum ParentType { Customer, Manager };
        private ParentType type;
        
        public EditCustomerForm(Customer selectedCustomer, ManagerForm form)
        {
            customer = selectedCustomer;
            managerParent = form;
            type = ParentType.Manager;
            InitializeComponent();
            EditCustInfoButton.Visible = false;
            FillTextBoxes();
        }
        public EditCustomerForm(Customer selectedCustomer, CustomerForm form)
        {
            customer = selectedCustomer;
            customerParent = form;
            type = ParentType.Customer;
            InitializeComponent();
            EditUserButton.Visible = false;
            TypeBox.Visible = false;
            FillTextBoxes();
        }
        private void FillTextBoxes()
        {
            FirstNameBox.Text = customer.Name.FirstName;
            LastNameBox.Text = customer.Name.LastName;
            SuiteBox.Text = customer.Address.SuiteNumber;
            StreetBox.Text = customer.Address.StreetNumber;
            ProvinceBox.Text = customer.Address.Province;
            PostalBox.Text = customer.Address.PostalCode;
            CityBox.Text = customer.Address.City;
            HouseBox.Text = customer.Address.HouseNumber;
            PhoneBox.Text = customer.ContactInformation.PhoneNumber;
            EmailBox.Text = customer.ContactInformation.Email;
            TypeBox.SelectedItem = customer.Type.ToString();
        }
        private Customer.AccountType GetAccountType()
        {
            Customer.AccountType type;

            if (TypeBox.SelectedItem == null)
            {
                throw new AccountTypeException();
            }
            String selection = TypeBox.SelectedItem.ToString();

            switch (selection)
            {
                case ("Limited"):
                    type = Customer.AccountType.Limited;
                    break;
                case ("Bronze"):
                    type = Customer.AccountType.Bronze;
                    break;
                case ("Silver"):
                    type = Customer.AccountType.Silver;
                    break;
                case ("Gold"):
                    type = Customer.AccountType.Gold;
                    break;
                default:
                    type = Customer.AccountType.Disabled;
                    break;
            }
            return type;
        }
        private void EditUser()
        {
            Customer updatedCustomer = customer;
            if (customer.Name.FirstName != FirstNameBox.Text)
            {
                updatedCustomer.Name.FirstName = FirstNameBox.Text;
            }
            if (customer.Name.LastName != LastNameBox.Text)
            {
                updatedCustomer.Name.LastName = LastNameBox.Text;
            }
            if (customer.Address.City != CityBox.Text)
            {
                updatedCustomer.Address.City = CityBox.Text;
            }
            if (customer.Address.HouseNumber != HouseBox.Text)
            {
                updatedCustomer.Address.HouseNumber = HouseBox.Text;
            }
            if (customer.Address.PostalCode != PostalBox.Text)
            {   
                if(PostalBox.Text == "")
                {
                    updatedCustomer.Address.PostalCode = "";
                }
                else
                {
                    updatedCustomer.Address.PostalCode = PostalBox.Text;
                }
            }
            if (customer.Address.Province != ProvinceBox.Text)
            {
                updatedCustomer.Address.Province = ProvinceBox.Text;
            }
            if (customer.Address.StreetNumber != StreetBox.Text)
            {
                updatedCustomer.Address.StreetNumber = StreetBox.Text;
            }
            if (customer.Address.SuiteNumber != SuiteBox.Text)
            {
                updatedCustomer.Address.SuiteNumber = SuiteBox.Text;
            }
            if (customer.ContactInformation.Email != EmailBox.Text)
            {
                if (EmailBox.Text == "")
                {
                    updatedCustomer.ContactInformation.Email = "";
                }
                else
                {
                    updatedCustomer.ContactInformation.Email = EmailBox.Text;
                }
            }
            if (customer.ContactInformation.PhoneNumber != PhoneBox.Text)
            {
                if (PhoneBox.Text == "")
                {
                    updatedCustomer.ContactInformation.PhoneNumber = "";
                }
                else
                {
                    updatedCustomer.ContactInformation.PhoneNumber = PhoneBox.Text;
                }
            }
            if (customer.Type.ToString() != TypeBox.SelectedItem.ToString())
            {
                updatedCustomer.Type = GetAccountType();
            }
            
            DBEnvironment.Edit(updatedCustomer);
            MessageBox.Show("Customer edit complete!");
        }
        private void EditUserButton_Click(object sender, EventArgs e)
        {
            buttonClick();   
        }

        private void buttonClick()
        {
            if ((MessageBox.Show("Edit Customer with current information?", "Confirm",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
    MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                EditUser();
                if (type == ParentType.Manager)
                {
                    managerParent.FillTable();
                }
                else
                {
                    customerParent.FillUserInfo();
                }

                this.Close();
            }
        }        
        private void CancelButton_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Cancel Customer Update? (Information will not be saved)", "Cancel",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                this.Close();
            }
        }

        private void EditCustInfoButton_Click(object sender, EventArgs e)
        {
            buttonClick();
        }
    }
}
