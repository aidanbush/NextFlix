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
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            UserName user = new UserName(FirstNameBox.Text, LastNameBox.Text);
            Address userAddress = new Address(SuiteBox.Text, StreetBox.Text, HouseBox.Text, CityBox.Text, ProvinceBox.Text, PostalBox.Text);
            ContactInformation userInfo = new ContactInformation(EmailBox.Text, PhoneBox.Text);
            CustomerInsertionParameters parameters = new CustomerInsertionParameters(user, userAddress, userInfo);
            DBEnvironment.CustomerInsertionQuery(parameters);
        }
    }
}
