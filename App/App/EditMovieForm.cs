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
    public partial class EditMovieForm : Form
    {
        Movie movie;
        ManagerForm parent;
        public EditMovieForm(Movie selected, ManagerForm upper)
        {
            movie = selected;
            parent = upper;
            InitializeComponent();
            FillBoxes();
        }
        private void FillBoxes()
        {

            TitleBox.Text = movie.Name;
            GenreBox.Text = movie.Genre;
            CopyAmountBox.Text = movie.Num_copies.ToString();
            FeesBox.Text = movie.Fees.ToString();
        }
        private bool EditMovie()
        {
            Movie edittedMovie = movie;

            if (TitleBox.Text != movie.Name)
            {
                Console.WriteLine("CHANGE TITLE");
                edittedMovie.Name = TitleBox.Text;
            }
            if (GenreBox.Text != movie.Genre)
            {
                edittedMovie.Genre = GenreBox.Text;
            }
            if (float.Parse(FeesBox.Text) != movie.Fees)
            {
                edittedMovie.Fees = (float.Parse(FeesBox.Text));
            }
            if (int.Parse(CopyAmountBox.Text) != movie.Num_copies)
            {
                edittedMovie.Num_copies = int.Parse(CopyAmountBox.Text);
            }
            if (DBEnvironment.Edit(edittedMovie))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void EditMovieButton_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Edit movie with current information?", "Confirm",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
    MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                EditMovie();
                Console.WriteLine("REFRESH");
                parent.FillTable();
                this.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Cancel movie update? (Information will not be saved)", "Cancel",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                this.Close();
            }
        }
    }
}
