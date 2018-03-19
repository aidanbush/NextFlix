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
        private int index;
        private BindingList<Customer> customers;
        public ManagerForm()
        {
            InitializeComponent();
            FillTable();
        }
        public void FillTable()
        {
            DBEnvironment.SetCustomers();
            customers = DBEnvironment.GetCustomers();
            dataGridView1.DataSource = customers;
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
            
            AddCustomerForm AddUserForm = new AddCustomerForm(this);
            AddUserForm.Show();

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
        private void EditButton_Click(object sender, EventArgs e)
        {
            Customer selectedCustomer = customers.ElementAt(index);
            EditCustomerForm editCustomerForm = new EditCustomerForm(selectedCustomer, this);
            editCustomerForm.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }
    }
}