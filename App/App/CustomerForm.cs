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

        private enum CustomerFormType { home, movie, rentMovie, myMovies, profile };
        private CustomerFormType currentType;

        public CustomerForm(Form newParent, Customer newUser)
        {
            parent = newParent;
            user = newUser;
            
            currentType = CustomerFormType.home;
            InitializeComponent();

            DBEnvironment.SetMovies();
            movies = DBEnvironment.GetMovies();
            MovieGridView.AutoGenerateColumns = true;

            HomePanel.Visible = true;
            ProfilePanel.Visible = false;
            rentMoviePanel.Visible = false;
            myMoviesPanel.Visible = false;
            
        }
        private void fillMovies()
        {
            MovieGridView.DataSource = movies;
            MovieGridView.Columns.Remove("id");
            MovieGridView.Columns.Remove("Num_copies");
        }
        private void myMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeFormType();
            currentType = CustomerFormType.myMovies;
            Console.WriteLine("Showing Movies");
            myMoviesPanel.Visible = true;
        }

        //Movie Home
        private void movieHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeFormType();
            currentType = CustomerFormType.rentMovie;
            rentMoviePanel.Visible = true;
            fillMovies();
        }
        //Rent Movie Button
        private void RentMovieButton_Click(object sender, EventArgs e)
        {
            ChangeFormType();
            currentType = CustomerFormType.rentMovie;
            Console.WriteLine("Showing Rent Movies");
            rentMoviePanel.Visible = true;
            fillMovies();
        }
        //MyProfile
        private void myProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeFormType();
            currentType = CustomerFormType.profile;
            Console.WriteLine("Showing profile");
            ProfilePanel.Visible = true;  
        }
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeFormType();
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


    }
}
