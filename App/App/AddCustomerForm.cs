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

        private void AddUserButton_Click(object sender, EventArgs e)
        {

            if ((MessageBox.Show("Add new Customer with current information?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                UserName user = new UserName(FirstNameBox.Text, LastNameBox.Text);
                Address userAddress = new Address(SuiteBox.Text, StreetBox.Text, HouseBox.Text, CityBox.Text, ProvinceBox.Text, PostalBox.Text);
                ContactInformation userInfo = new ContactInformation(EmailBox.Text, PhoneBox.Text);
                CustomerInsertionParameters parameters = new CustomerInsertionParameters(user, userAddress, userInfo);
                bool insert = DBEnvironment.CustomerInsertionQuery(parameters);

                if (insert == false)
                {
                    MessageBox.Show("There was an error adding the Customer." +
                                    "\nCheck your fields and try again.");
                }

                else
                {
                    MessageBox.Show("Customer successfully added!");
                    parent.Refresh();
                    this.Close();
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Cancel Customer Entry?", "Cancel",
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
            this.PhoneBox.Enter += new EventHandler(PhoneBox_Enter);
            this.PhoneBox.Leave += new EventHandler(PhoneBox_Leave);
            this.EmailBox.Enter += new EventHandler(EmailBox_Enter);
            this.EmailBox.Leave += new EventHandler(EmailBox_Leave);
            defaultSetText();
            
        }

        protected void defaultSetText()
        {
            this.PhoneBox.Text = ("(xxx) xxx-xxxx");
            PhoneBox.ForeColor = Color.Gray;
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
        protected void PhoneBoxSetText()
        {
            this.PhoneBox.Text = ("(xxx) xxx-xxxx");
            PhoneBox.ForeColor = Color.Gray;
        }
        private void PhoneBox_Enter(object sender, EventArgs e)
        {
            if (PhoneBox.ForeColor == Color.Black)
                return;
            PhoneBox.Text = "";
            PhoneBox.ForeColor = Color.Black;
        }
        private void PhoneBox_Leave(object sender, EventArgs e)
        {
            if (PhoneBox.Text.Trim() == "")
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

    }
}
