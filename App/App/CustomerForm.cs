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
    public partial class CustomerForm : Form
    {
        private Form parent;
        private Customer user;
        private BindingList<Movie> movies;
        private BindingList<Movie> userQueue;
        private int index;
        private enum CustomerFormType { home, movie, rentMovie, myMovies, profile };
        private CustomerFormType currentType;

        public CustomerForm(Form newParent, Customer newUser)
        {
            parent = newParent;
            user = newUser;
            
            currentType = CustomerFormType.home;
            InitializeComponent();
            FillUserInfo();
            DBEnvironment.SetMovies();
            movies = DBEnvironment.GetMovies();
            userQueue = DBEnvironment.RetrieveCustomerQueue(user);
            fillMovies();
            MoviesQueuedGridView.AutoGenerateColumns = true;
            MovieGridView.AutoGenerateColumns = true;
            MovieGridView.Columns["Id"].Visible = false;
            MovieGridView.Columns["Num_copies"].Visible = false;
            MoviesQueuedGridView.Columns["Id"].Visible = false;
            MoviesQueuedGridView.Columns["Num_copies"].Visible = false;

            HidePanels();
            
        }
        private void HidePanels()
        {
            HomePanel.Visible = true;
            ProfilePanel.Visible = false;
            rentMoviePanel.Visible = false;
            myMoviesPanel.Visible = false;
        }
        private void FillUserInfo()
        {
            NameLabel.Text = "Name:" + user.Name.FirstName + " " + user.Name.LastName;
            AddressLabel.Text = "Address: " + user.Address.HouseNumber + " " + user.Address.StreetNumber;
            PhoneLabel.Text = "Phone number: " + user.ContactInformation.CleanNumberForOutput();
            CityLabel.Text = "City: " + user.Address.City;
            ProvinceLabel.Text = "Province: " + user.Address.Province;
            EmailLabel.Text = "Email: " + user.ContactInformation.Email;
        }
        
        private void fillMovies()
        {
            MovieGridView.DataSource = movies;
            MoviesQueuedGridView.DataSource = userQueue;

        }
        private void myMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeFormType();
            fillMovies();
            currentType = CustomerFormType.myMovies;
            Console.WriteLine("Showing Movies");
            myMoviesPanel.Visible = true;
        }

        //Movie Home
        private void movieHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeFormType();
            fillMovies();
            currentType = CustomerFormType.rentMovie;
            rentMoviePanel.Visible = true;
            
        }
        //Rent Movie Button
        private void RentMovieButton_Click(object sender, EventArgs e)
        {
            ChangeFormType();
            fillMovies();
            currentType = CustomerFormType.rentMovie;
            Console.WriteLine("Showing Rent Movies");
            rentMoviePanel.Visible = true;
            
        }
        //MyProfile
        private void myProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeFormType();
            fillMovies();
            currentType = CustomerFormType.profile;
            Console.WriteLine("Showing profile");
            ProfilePanel.Visible = true;  
        }
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeFormType();
            fillMovies();
            currentType = CustomerFormType.home;
            Console.WriteLine("Showing home");
            HomePanel.Visible = true;
        }

        private void ChangeFormType()
        {
            switch (currentType)
            {
                case (CustomerFormType.home):
                    HomePanel.Visible = false;
                    break;
                case (CustomerFormType.profile):
                    ProfilePanel.Visible = false;
                    break;
                case (CustomerFormType.myMovies):
                    myMoviesPanel.Visible = false;
                    break;
                case (CustomerFormType.rentMovie):
                    rentMoviePanel.Visible = false;
                    break;
            }
        }


        private void HomePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CustomerFormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void rentMoviePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RentButton_click(object sender, EventArgs e)
        {
            Movie selectedMovie = movies.ElementAt(index);
            MovieViewForm movieForm = new MovieViewForm(selectedMovie, this.user);
            movieForm.Show();
        }

        private void MovieGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }
    }
}
