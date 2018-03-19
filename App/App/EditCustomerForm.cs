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
        Customer customer;
        ManagerForm parent;
        
        public EditCustomerForm(Customer selectedCustomer, ManagerForm form)
        {
            customer = selectedCustomer;
            parent = form;
            InitializeComponent();
            FirstNameBox.Text = customer.Name.FirstName;
            LastNameBox.Text = customer.Name.LastName;
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
                Console.WriteLine("CHANGING LAST FROM " + updatedCustomer.Name.LastName + " to " + FirstNameBox.Text);
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
                updatedCustomer.Address.PostalCode = PostalBox.Text;
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
                updatedCustomer.ContactInformation.Email = EmailBox.Text;
            }
            if (customer.ContactInformation.PhoneNumber != PhoneBox.Text)
            {
                updatedCustomer.ContactInformation.PhoneNumber = PhoneBox.Text;
            }
            /*if (customer.Type.ToString() != TypeBox.SelectedItem.ToString())
            {
                updatedCustomer.Type = GetType();

            }*/
            DBEnvironment.Edit(updatedCustomer);
            MessageBox.Show("Great Success!");
        }
        private void EditUserButton_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Edit Customer with current information?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                EditUser();
                Console.WriteLine("REFRESH");
                parent.FillTable();
                this.Close();
            }
                

        }

        private void EditCustomerForm_Load(object sender, EventArgs e)
        {

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
    }
}
