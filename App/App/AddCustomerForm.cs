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
    public partial class AddCustomerForm : Form
    {
        private ManagerForm parent;

        public AddCustomerForm(ManagerForm frm)
        {
            parent = frm;
            InitializeComponent();
        }

        private bool InputsValid()
        {
            string msg = "";
            if (FirstNameBox.Text == "")
                msg += "First name cannot be blank.\n";

            if (LastNameBox.Text == "")
                msg += "Last name cannot be blank.\n";

            if (UsernameTextBox.Text == "")
                msg += "Username cannot be blank.\n";
            else if (!DBEnvironment.CustomerUsernameAvailablility(UsernameTextBox.Text))
                msg += "Username unavailable.\n";

            if (PasswordTextBox.Text == "")
                msg += "Password cannot be blank.\n";

            if (msg != "")
            {
                MessageBox.Show(msg);
                return false;
            }

            return true;
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

        private String CheckBlankBoxes(TextBox box)
        {
            String outString;
            Console.WriteLine("TEST VALUE");
            switch (box.Text)
            {
                case ("eg t1t1t1"):
                    Console.WriteLine("Blank postal");
                    outString = "";
                    break;
                case ("eg username@email.com"):
                    Console.WriteLine("Blank email");
                    outString = "";
                    break;
                case (""):
                    outString = "";
                    break;
                default:
                    Console.WriteLine("Should work");
                    Console.WriteLine(EmailBox.Text);
                    outString = box.Text;
                    break;
            }
            Console.WriteLine("OUT");
            return outString;
        }

        private Customer CreateCustomer()
        {  
            String postal = CheckBlankBoxes(PostalBox);
            String email = CheckBlankBoxes(EmailBox);
            String phone = CheckBlankBoxes(PhoneBox);

            Customer.AccountType type = GetAccountType();
            UserName user = new UserName(FirstNameBox.Text, LastNameBox.Text);
            Address userAddress = new Address(SuiteBox.Text, StreetBox.Text, HouseBox.Text, CityBox.Text, ProvinceBox.Text, postal);
            ContactInformation userInfo = new ContactInformation(email, phone);
            Customer newCustomer = new Customer(user, userAddress, userInfo, type);

            return newCustomer;
        }

        private bool InsertUser()
        { 
            if ((MessageBox.Show("Add new Customer with current information?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                try
                {
                    Customer newCustomer = CreateCustomer();
                    DBEnvironment.Add(newCustomer);
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
            if (!InputsValid())
                return;

            if (InsertUser() == true)
            {
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

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            this.PostalBox.Enter += new EventHandler(PostalBox_Enter);
            this.PostalBox.Leave += new EventHandler(PostalBox_Leave);
            this.EmailBox.Enter += new EventHandler(EmailBox_Enter);
            this.EmailBox.Leave += new EventHandler(EmailBox_Leave);
            defaultSetText();
        }

        protected void defaultSetText()
        {
            this.PostalBox.Text = "eg t1t1t1";
            PostalBox.ForeColor = Color.Gray;
            this.EmailBox.Text = "eg username@email.com";
            EmailBox.ForeColor = Color.Gray;
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
  
        private void EmailBox_Enter(object sender, EventArgs e)
        {
            if (EmailBox.ForeColor == Color.Black)
                return;
            EmailBox.Text = "";
            EmailBox.ForeColor = Color.Black;
        }

        private void EmailBox_Leave(object sender, EventArgs e)
        {
            if (EmailBox.Text.Trim() == "")
                defaultSetText();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
