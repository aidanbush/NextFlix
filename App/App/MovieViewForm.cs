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
    public partial class MovieViewForm : Form
    {
        Movie movie;
        Customer user;
        public MovieViewForm(Movie selectedMovie, Customer CurrentUser)
        {
            movie = selectedMovie;
            user = CurrentUser;
            InitializeComponent();
            NameLabel.Text = movie.Name;
            GenreLabel.Text = movie.Genre;
            RatingLabel.Text = movie.Rating.ToString();
            CopyLabel.Text = movie.Num_copies.ToString();

        }

        private void RentButton_Click(object sender, EventArgs e)
        {
            AddToQueue adder = new AddToQueue(movie, user);
            if (adder.MovieInQueue())
            {
                MessageBox.Show("Movie is already in your queue");
                return;
            }
            if (DBEnvironment.AddToQueue(adder))
            {
                MessageBox.Show("Movie has been added to your queue!");
            }
            else
            {
                MessageBox.Show("Movie could not be added");
            }
        }
    }
}
