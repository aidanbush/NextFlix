using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private BindingList<Movie> currentlyRented;
        private BindingList<Movie> pending;
        private BindingList<Movie> pastRented;
        private int index;
        private int indexRentedThisMonth = 0;
        private int indexCurrentlyRented = 0;
        private enum CustomerFormType { home, movie, rentMovie, myMovies, profile };
        private CustomerFormType currentType;

        public CustomerForm(Form newParent, Customer newUser)
        {
            parent = newParent;
            user = newUser;

            currentType = CustomerFormType.home;
            InitializeComponent();
            FillUserInfo();
            
            fillMovies();

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
        
        public void fillMovies()
        {
            DBEnvironment.SetMovies();
            movies = DBEnvironment.GetMovies();
            userQueue = DBEnvironment.RetrieveCustomerQueue(user);
            pending = DBEnvironment.RetrieveCustomerPending(user);
            currentlyRented = DBEnvironment.GetCurrentlyRentedMovies(user);
            pastRented = DBEnvironment.GetRentedInPast(user);

            MovieGridView.DataSource = movies;
            MoviesQueuedGridView.DataSource = userQueue;
            RentedMoviesGridView.DataSource = currentlyRented;
            MoviesRentedThisMonth.DataSource = pastRented;
            MoviesPendingDataGridView.DataSource = pending;

            MovieGridView.Columns["Id"].Visible = false;
            MovieGridView.Columns["Num_copies"].Visible = false;
            MovieGridView.Columns["Copies_available"].Visible = false;
            MovieGridView.Columns["customerRating"].Visible = false;

            MoviesQueuedGridView.Columns["Id"].Visible = false;
            MoviesQueuedGridView.Columns["Num_copies"].Visible = false;
            MoviesQueuedGridView.Columns["Copies_available"].Visible = false;
            MoviesQueuedGridView.Columns["customerRating"].Visible = false;

            RentedMoviesGridView.Columns["Id"].Visible = false;
            RentedMoviesGridView.Columns["Num_copies"].Visible = false;
            RentedMoviesGridView.Columns["Copies_available"].Visible = false;
            RentedMoviesGridView.Columns["customerRating"].Visible = false;

            MoviesRentedThisMonth.Columns["Id"].Visible = false;
            MoviesRentedThisMonth.Columns["Num_copies"].Visible = false;
            MoviesRentedThisMonth.Columns["Copies_available"].Visible = false;
            MoviesRentedThisMonth.Columns["customerRating"].HeaderText = "Your Rating";

            MoviesPendingDataGridView.Columns["Id"].Visible = false;
            MoviesPendingDataGridView.Columns["Num_copies"].Visible = false;
            MoviesPendingDataGridView.Columns["Copies_available"].Visible = false;
            MoviesPendingDataGridView.Columns["customerRating"].Visible = false;
        }

        private void myMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeFormType();
            userQueue = DBEnvironment.RetrieveCustomerQueue(user);
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
            MovieViewForm movieForm = new MovieViewForm(selectedMovie, this.user, false, this);
            movieForm.Show();
        }

        private void MovieGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            index = e.RowIndex;
            MovieGridView.Rows[index].Selected = true;
        }

        private void MoviesQueuedGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MoviesRentedThisMonth_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            indexRentedThisMonth = e.RowIndex;
            MoviesRentedThisMonth.Rows[indexRentedThisMonth].Selected = true;
        }

        private void RateMovieButton_Click(object sender, EventArgs e)
        {
            if (indexRentedThisMonth < 0)
                return;

            Movie movie = pastRented[indexRentedThisMonth];
            MovieViewForm movieForm = new MovieViewForm(movie, this.user, true, this);
            movieForm.Show();
        }

        private void ReturnMovieButton_Click(object sender, EventArgs e)
        {
            if (indexCurrentlyRented < currentlyRented.Count)
            {
                Debug.WriteLine("returnMovieBtn Click ", indexCurrentlyRented);
            }

            Movie movie = currentlyRented[indexCurrentlyRented];

            if (DBEnvironment.ReturnMovie(movie, user))
            {
                //if no in past update past
                if (pastRented.SingleOrDefault(_ => _.Id == movie.Id) == null)
                {
                    pastRented = DBEnvironment.GetRentedInPast(user);
                    MoviesRentedThisMonth.DataSource = pastRented;
                }
                currentlyRented.RemoveAt(indexCurrentlyRented);
            }
        }

        private void MoviesCurrentlyRentedCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            indexCurrentlyRented = e.RowIndex;
        }
    }
}
