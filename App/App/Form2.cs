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
        public enum EmploymentRole { manager, employee };
        private EmploymentRole role;

        private int index;
        private enum FormType { customer, employee, movie, manager};
        private FormType currentFormType;

        // binding lists
        private BindingList<Customer> customers;
        private BindingList<Movie> movies;
        private BindingList<Employee> employees;

        private CustomerView customerView;
        private EmployeeView employeeView;
        private MovieView movieView;
        private ManagerView managerView;

        public ManagerForm(EmploymentRole newRole)
        {
            role = newRole;

            customers = DBEnvironment.GetCustomers();
            movies = DBEnvironment.GetMovies();
            employees = DBEnvironment.GetEmployees();
            
            customerView = new CustomerView(this);
            employeeView = new EmployeeView(this);
            movieView = new MovieView(this);
            managerView = new ManagerView(this);
            
            InitializeComponent();
            
            if (role != EmploymentRole.manager)
            {
                this.Text = "Employee";
                customerRepresentativesToolStripMenuItem.Visible = false;
                salesReportsToolStripMenuItem.Visible = false;
            }

            dataGridView1.AutoGenerateColumns = true;
            ChangeView(FormType.customer);
        }

        public void FillTable()
        {
            ChangeView(currentFormType);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ChangeView(currentFormType);
        }

        private void ChangeView(FormType newForm)
        {
            Debug.WriteLine("ChangeView");
            switch (currentFormType)
            {
                case FormType.customer:
                    customerView.HideView();
                    break;
                case FormType.employee:
                    employeeView.HideView();
                    break;
                case FormType.manager:
                    managerView.HideView();
                    break;
                case FormType.movie:
                    movieView.HideView();
                    break;
                default:
                    break;
            }

            currentFormType = newForm;

            switch (currentFormType)
            {
                case FormType.customer:
                    customerView.ShowView();
                    break;
                case FormType.employee:
                    employeeView.ShowView();
                    break;
                case FormType.manager:
                    managerView.ShowView();
                    break;
                case FormType.movie:
                    movieView.ShowView();
                    break;
                default:
                    Debug.WriteLine("default");
                    break;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (currentFormType)
            {
                case FormType.customer:
                    AddCustomerForm addUserForm = new AddCustomerForm(this);
                    addUserForm.Show();
                    break;
                case FormType.employee:
                    EmployeeAddEdit addForm = new EmployeeAddEdit(null, this);
                    addForm.Show();
                    break;
                case FormType.movie:
                    AddMovieForm addMovieForm = new AddMovieForm(this);
                    addMovieForm.Show();
                    break;
                case FormType.manager:
                    break;
            }
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
            ChangeView(currentFormType);

            Debug.WriteLine("Updated Ratings");
        }
        
        private void EditButton_Click(object sender, EventArgs e)
        {
            switch (currentFormType)
            {
                case FormType.customer:
                    Customer selectedCustomer = customers.ElementAt(index);
                    EditCustomerForm editCustomerForm = new EditCustomerForm(selectedCustomer, this);
                    editCustomerForm.Show();
                    break;
                case FormType.employee:
                    Employee selectedEmployee = employees.ElementAt(index);
                    EmployeeAddEdit editForm = new EmployeeAddEdit(selectedEmployee, this);
                    editForm.Show();
                    break;
                case FormType.movie:
                    Movie selectedMovie = movies.ElementAt(index);
                    EditMovieForm editMovieForm = new EditMovieForm(selectedMovie, this);
                    editMovieForm.Show();
                    break;
                case FormType.manager:
                    break;
            }

        }
    
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            switch (currentFormType)
            {
                case FormType.customer:
                    DeleteCustomer();
                    break;
                case FormType.employee:
                    DeleteEmployee();
                    break;
                case FormType.movie:
                    DeleteMovie();
                    break;
                case FormType.manager:
                    break;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void CustomerLoad(object sender, EventArgs e)
        {
            Debug.WriteLine("CustomerLoad");
            ChangeView(FormType.customer);
        }

        private void CustomerRepLoad(object sender, EventArgs e)
        {
            Debug.WriteLine("CustomerRepLoad");
            ChangeView(FormType.employee);
        }

        private void MoviesLoad(object sender, EventArgs e)
        {
            Debug.WriteLine("MoviesLoad");
            ChangeView(FormType.movie);
        }

        private void SalesRepotsLoad(object sender, EventArgs e)
        {
            Debug.WriteLine("SalesReportsLoad");
            ChangeView(FormType.manager);
        }

        private void DeleteCustomer()
        {
            Customer selectedCustomer = customers.ElementAt(index);
            ConfirmationForm confirmation = new ConfirmationForm(this, selectedCustomer, "are you sure you want to delete " + selectedCustomer.FirstName + " " + selectedCustomer.LastName + "?");
            confirmation.Show();
        }

        private void DeleteMovie()
        {
            Movie selectedMovie = movies.ElementAt(index);
            ConfirmationForm confirmation = new ConfirmationForm(this, selectedMovie, "are you sure you want to delete " + selectedMovie.Name + "?");
            confirmation.Show();
        }

        private void DeleteEmployee()
        {
            Employee selectedEmployee = employees.ElementAt(index);
            ConfirmationForm confirmation = new ConfirmationForm(this, selectedEmployee, "are you sure you want to delete " + selectedEmployee.FirstName + " " + selectedEmployee.LastName + "?");
            confirmation.Show();
        }

        public void Reload(object sender, EventArgs e)
        {
            this.Form2_Load(sender, e);
        }

        private interface IView
        {
            void ShowView();
            void HideView();
        }

        private class CustomerView : IView
        {
            private ManagerForm parent;

            public CustomerView(ManagerForm newParent)
            {
                parent = newParent;
            }

            public void HideView()
            {
                // buttons
                parent.AddButton.Hide();
                parent.EditButton.Hide();
                parent.DeleteButton.Hide();
                parent.UpdateRatingsButton.Hide();
                // other
                parent.dataGridView1.Hide();
            }

            public void ShowView()
            {
                Debug.WriteLine("ShowCustomerView");
                // buttons
                parent.AddButton.Show();
                parent.EditButton.Show();
                parent.DeleteButton.Show();
                parent.UpdateRatingsButton.Show();
                // other
                parent.dataGridView1.Show();

                // setup dataGridView
                DBEnvironment.SetCustomers();
                parent.customers = DBEnvironment.GetCustomers();
                parent.dataGridView1.DataSource = parent.customers;
                // refactor to specify all columns
                parent.dataGridView1.Columns.Remove("Address");
                parent.dataGridView1.Columns.Remove("Name");
                parent.dataGridView1.Columns.Remove("ContactInformation");

                parent.Refresh();
            }
        }

        private class EmployeeView : IView
        {
            private ManagerForm parent;

            public EmployeeView(ManagerForm newParent)
            {
                parent = newParent;
            }

            public void HideView()
            {
                // buttons
                parent.AddButton.Hide();
                parent.EditButton.Hide();
                parent.DeleteButton.Hide();
                parent.UpdateRatingsButton.Hide();
                // other
                parent.dataGridView1.Hide();
            }

            public void ShowView()
            {
                Debug.WriteLine("ShowEmployeeView");
                // buttons
                parent.AddButton.Show();
                parent.EditButton.Show();
                parent.DeleteButton.Show();
                // other
                parent.dataGridView1.Show();

                // setup dataGridView
                DBEnvironment.SetEmployees();
                parent.employees = DBEnvironment.GetEmployees();
                parent.dataGridView1.DataSource = parent.employees;
                // refactor to specify names
                parent.dataGridView1.Columns.Remove("Address");
                parent.dataGridView1.Columns.Remove("Name");
                parent.dataGridView1.Columns.Remove("ContactInformation");

                parent.Refresh();
            }
        }

        private class MovieView : IView
        {
            private ManagerForm parent;

            public MovieView(ManagerForm newParent)
            {
                parent = newParent;
            }

            public void HideView()
            {
                // buttons
                parent.AddButton.Hide();
                parent.EditButton.Hide();
                parent.DeleteButton.Hide();
                parent.UpdateRatingsButton.Hide();
                // other
                parent.dataGridView1.Hide();
            }

            public void ShowView()
            {
                Debug.WriteLine("ShowMovieView");
                // buttons
                parent.AddButton.Show();
                parent.EditButton.Show();
                parent.DeleteButton.Show();
                // other
                parent.dataGridView1.Show();

                // setup dataGridView
                DBEnvironment.SetMovies();
                parent.movies = DBEnvironment.GetMovies();
                parent.dataGridView1.DataSource = parent.movies;

                parent.Refresh();
            }
        }

        private class ManagerView : IView
        {
            private ManagerForm parent;

            public ManagerView(ManagerForm newParent)
            {
                parent = newParent;
            }

            public void HideView()
            {
            }

            public void ShowView()
            {
            }
        }
    }
}