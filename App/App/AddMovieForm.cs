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
    public partial class AddMovieForm : Form
    {
        ManagerForm parent;
        public AddMovieForm(ManagerForm manager)
        {
            parent = manager;
            InitializeComponent();
        }

        private void AddMovieButton_Click(object sender, EventArgs e)
        {
            String title = TitleBox.Text;
            String genre = GenreBox.Text;
            int copies = int.Parse(CopyAmountBox.Text);
            float fees = float.Parse(FeesBox.Text);

            Movie newMovie = new Movie(title, genre, fees, copies, copies, 0);
            DBEnvironment.Add(newMovie);
            parent.FillTable();
            MessageBox.Show("SUCCESS");
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
