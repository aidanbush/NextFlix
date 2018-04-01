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
            Console.WriteLine("User id: " + user.Id.ToString());
            Console.WriteLine(movie.Name + " id: " + movie.Id.ToString());
            Console.WriteLine("date: " + adder.CreationDate.ToString());
            DBEnvironment.AddToQueue(adder);
        }
    }
}
