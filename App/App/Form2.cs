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
        private enum FormType { customer, employee, movie, manager};
        private FormType currentFormType;

        public ManagerForm()
        {
            InitializeComponent();
            currentFormType = FormType.customer;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            BindingList<Customer> customers;
            BindingList<Employee> employees;

            if (this.currentFormType == FormType.customer)
            {
                DBEnvironment.SetCustomers();
                customers = DBEnvironment.GetCustomers();
                dataGridView1.DataSource = customers;
            }
            else if (this.currentFormType == FormType.employee)
            {
                DBEnvironment.SetEmployees();
                employees = DBEnvironment.GetEmployees();
                dataGridView1.DataSource = employees;
            }

            
            dataGridView1.AutoGenerateColumns = true;
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
    }
}