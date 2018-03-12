using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
            dataGridView1.DataMember = "Customers";
            dataGridView1.DataSource = DBEnvironment.getDataSet("Customers");
            dataGridView1.AutoGenerateColumns = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            UserName user = new UserName("STUFF", "Last Name");
            Address userAddress = new Address("123", "some Streeet", "some more txt", "crap", "AB", "t5t5t5");
            ContactInformation userInfo = new ContactInformation("emasdf@asd.ca", "0021233487");
            Customer c = new Customer(user, userAddress, userInfo, Customer.AccountType.Bronze);
            DBEnvironment.Add(c);
            
            //AddCustomerForm AddUserForm = new AddCustomerForm(this);
            //AddUserForm.Show();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {


            
        }

        private void UpdateRatingsButton_Click(object sender, EventArgs e)
        {
            DBEnvironment.UpdateRatings();
            // reload view
            Debug.WriteLine("Updated Ratings");

        }
    }
}