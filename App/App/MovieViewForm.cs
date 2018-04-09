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
    public partial class MovieViewForm : Form
    {
        Movie movie;
        Customer user;
        BindingList<Actor> actorsInMovie;
        CustomerForm parent;
        public MovieViewForm(Movie selectedMovie, Customer CurrentUser, bool canRate, CustomerForm parent)

        {
            this.parent = parent;
            movie = selectedMovie;
            user = CurrentUser;
            InitializeComponent();
            NameLabel.Text = movie.Name;
            GenreLabel.Text = movie.Genre;
            RatingLabel.Text = movie.Rating.ToString();
            CopyLabel.Text = movie.Num_copies.ToString();
            BindingList<Actor> actors = DBEnvironment.RetrieveActors();
            Starred starred = new Starred(actors.ToArray(), null, movie);
            actorsInMovie = DBEnvironment.GetStarred(movie);
            MovieCastLabel.Text = CreateStarredText();
            RatingButton.Hide();
            RatingSlider.Hide();

            if (canRate)
            {
                RatingButton.Show();
                RatingSlider.Show();
                RentButton.Hide();
            }
        }
        private string CreateStarredText()
        {
            string outString = "Starring: ";
            string actors = "";
            foreach(Actor actor in actorsInMovie)
            {
                actors += actor.Name.GetFullName() + ", ";
            }
            int index = actors.LastIndexOf(",");
            actors = actors.Remove(index);
            outString += actors;
            return outString;

        }
        private void RentButton_Click(object sender, EventArgs e)
        {
            AddToQueue adder = new AddToQueue(movie, user);
            if (adder.MovieInQueue())
            {
                MessageBox.Show("Movie is already in your queue");
                this.Close();
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
            this.Close();
        }

        private void MovieViewForm_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            RatingLabel.Text = RatingSlider.Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void RatingButton_Click(object sender, EventArgs e)
        {
            if (DBEnvironment.AddMovieRating(movie, user, int.Parse(RatingLabel.Text)))
            {
                Debug.Print("Adding movie rating!");
                return;
            }
            else
            {
                Debug.Print("Updating movie rating");
                DBEnvironment.EditMovieRating(movie, user, int.Parse(RatingLabel.Text));
                this.parent.fillMovies();
                this.Close();
            }
                
        }
    }
}
