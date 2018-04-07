﻿using System;
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
        public MovieViewForm(Movie selectedMovie, Customer CurrentUser, bool canRate)
        {
            movie = selectedMovie;
            user = CurrentUser;
            InitializeComponent();
            NameLabel.Text = movie.Name;
            GenreLabel.Text = movie.Genre;
            RatingLabel.Text = movie.Rating.ToString();
            CopyLabel.Text = movie.Num_copies.ToString();
            RatingButton.Hide();
            RatingSlider.Hide();

            if (canRate)
            {
                RatingButton.Show();
                RatingSlider.Show();
                RentButton.Hide();
            }
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
                return;
            else
                DBEnvironment.EditMovieRating(movie, user, int.Parse(RatingLabel.Text));
        }
    }
}
