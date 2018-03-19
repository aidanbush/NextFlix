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
        private BindingList<Movie> movies;
        private enum FormType { customer, employee, movie, manager};
        private FormType currentFormType;
        public ManagerForm()
        {
            DBEnvironment.SetCustomers();
            customers = DBEnvironment.GetCustomers();

            InitializeComponent();
            currentFormType = FormType.customer;
            FillTable();
        }
        public void FillTable()
        {
            switch (currentFormType)
            {
                case (FormType.customer):
                    Console.WriteLine("FORM SET TO CUSTOMERS");
                    DBEnvironment.SetCustomers();
                    customers = DBEnvironment.GetCustomers();
                    dataGridView1.DataSource = customers;
                    break;

                case (FormType.movie):
                    Console.WriteLine("FORM SET TO MOVIES");
                    DBEnvironment.SetMovies();
                    movies = DBEnvironment.GetMovies();
                    dataGridView1.DataSource = movies;
                    break;

                default:
                    this.Close();
                    break;
            }

            dataGridView1.AutoGenerateColumns = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (this.currentFormType == FormType.customer)
            {
                dataGridView1.DataSource = customers;
                // refactor to specify all columns
                dataGridView1.Columns.Remove("Address");
                dataGridView1.Columns.Remove("Name");
                dataGridView1.Columns.Remove("ContactInformation");
            }
            else if (this.currentFormType == FormType.employee)
            {
                BindingList<Employee> employees;
                DBEnvironment.SetEmployees();
                employees = DBEnvironment.GetEmployees();
                dataGridView1.DataSource = employees;
            }
            else if (this.currentFormType == FormType.movie)
            {
                BindingList<Movie> movies;
                DBEnvironment.SetMovies();
                movies = DBEnvironment.GetMovies();
                dataGridView1.DataSource = movies;
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

        private void CustomerLoad(object sender, EventArgs e)
        {
            currentFormType = FormType.customer;
        }

        private void CustomerRepLoad(object sender, EventArgs e)
        {
            currentFormType = FormType.employee;
        }

        private void MoviesLoad(object sender, EventArgs e)
        {
            currentFormType = FormType.movie;
        }

        private void SalesRepotsLoad(object sender, EventArgs e)
        {

        }
    }
}