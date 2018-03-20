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
        private enum FormType { customer, employee, movie, manager};
        private FormType currentFormType;

        // binding lists
        private BindingList<Customer> customers;
        private BindingList<Movie> movies;
        private BindingList<Employee> employees;

        public ManagerForm()
        {
            customers = DBEnvironment.GetCustomers();
            movies = DBEnvironment.GetMovies();
            employees = DBEnvironment.GetEmployees();

            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
            currentFormType = FormType.manager;
            ChangeView();
        }

        public void FillTable()
        {
            switch (currentFormType)
            {
                case (FormType.customer):
                    ShowCustomerView();
                    break;

                case (FormType.movie):
                    Console.WriteLine("FORM SET TO MOVIES");
                    ShowMovieView();
                    break;

                case (FormType.employee):
                    ShowEmployeeView();
                    break;

                default:
                    this.Close();
                    break;
            }

            dataGridView1.AutoGenerateColumns = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            switch (currentFormType)
            {
                case FormType.customer:
                    ShowCustomerView();
                    break;

                case FormType.employee:
                    ShowEmployeeView();
                    break;

                case FormType.movie:
                    ShowMovieView();
                    break;
            }
        }

        private void ChangeView()
        {
            Debug.WriteLine("ChangeView");
            // hide buttons
            AddButton.Hide();
            EditButton.Hide();
            DeleteButton.Hide();
            UpdateRatingsButton.Hide();

            switch (currentFormType)
            {
                case FormType.customer:
                    Debug.WriteLine("formtype.customer");
                    ShowCustomerView();
                    break;
                case FormType.employee:
                    Debug.WriteLine("formtype.employee");
                    ShowEmployeeView();
                    break;
                case FormType.manager:
                    Debug.WriteLine("formtype.manager");
                    ShowManagerView();
                    break;
                case FormType.movie:
                    Debug.WriteLine("formtype.movie");
                    ShowMovieView();
                    break;
                default:
                    Debug.WriteLine("default");
                    break;
            }
        }

        private void ShowCustomerView()
        {
            Debug.WriteLine("ShowCustomerView");
            // show buttons
            AddButton.Show();
            EditButton.Show();
            DeleteButton.Show();
            UpdateRatingsButton.Show();

            // setup dataGridView
            DBEnvironment.SetCustomers();
            customers = DBEnvironment.GetCustomers();
            dataGridView1.DataSource = customers;
            // refactor to specify all columns
            dataGridView1.Columns.Remove("Address");
            dataGridView1.Columns.Remove("Name");
            dataGridView1.Columns.Remove("ContactInformation");
            
            Refresh();
        }

        private void ShowEmployeeView()
        {
            Debug.WriteLine("ShowEmployeeView");
            // show buttons
            AddButton.Show();
            EditButton.Show();
            DeleteButton.Show();
            
            // setup dataGridView
            DBEnvironment.SetEmployees();
            employees = DBEnvironment.GetEmployees();
            dataGridView1.DataSource = employees;
            
            Refresh();
        }

        private void ShowManagerView()
        {
            // show buttons
            AddButton.Show();
            EditButton.Show();
            DeleteButton.Show();

            //fill with nothing
            dataGridView1.DataSource = new BindingList<string>();

            Refresh();
        }

        private void ShowMovieView()
        {
            Debug.WriteLine("ShowMovieView");
            // show buttons
            AddButton.Show();
            EditButton.Show();
            DeleteButton.Show();

            // setup dataGridView
            DBEnvironment.SetMovies();
            movies = DBEnvironment.GetMovies();
            dataGridView1.DataSource = movies;

            Refresh();
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
            Debug.WriteLine("CustomerLoad");
            currentFormType = FormType.customer;
            ChangeView();
        }

        private void CustomerRepLoad(object sender, EventArgs e)
        {
            Debug.WriteLine("CustomerRepLoad");
            currentFormType = FormType.employee;
            ChangeView();
        }

        private void MoviesLoad(object sender, EventArgs e)
        {
            Debug.WriteLine("MoviesLoad");
            currentFormType = FormType.movie;
            ChangeView();
        }

        private void SalesRepotsLoad(object sender, EventArgs e)
        {
            Debug.WriteLine("SalesReportsLoad");

            ChangeView();
        }
    }
}