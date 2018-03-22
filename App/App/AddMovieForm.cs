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
        private bool InsertMovie()
        {
            if ((MessageBox.Show("Add new Customer with current information?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                
                try
                {
                    String title = TitleBox.Text;
                    String genre = GenreBox.Text;
                    int copies = int.Parse(CopyAmountBox.Text);
                    float fees = float.Parse(FeesBox.Text);
                    Movie newMovie = new Movie(title, genre, fees, copies, copies, 0);
                    
                    DBEnvironment.Add(newMovie);
                                        return true;
                }
                catch (Exception Ex)
                {
                    //HandleException(Ex);
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        private bool CheckTextBoxes()
        {
            Console.WriteLine("Should b hur");
            if(TitleBox.Text == "" && CopyAmountBox.Text == "")
            {
                MessageBox.Show("Plese check the movie title and Copy amount");
                return false;
            }
            else if(TitleBox.Text == "")
            {
                MessageBox.Show("Please check the title");
                return false;
            }
            else if(CopyAmountBox.Text == "")
            {
                MessageBox.Show("Please check the movie copy amount");
                return false;
            }
            else
            {
                return true;
            }
        }
        
        private void AddMovieButton_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                if (InsertMovie())
                {
                    parent.FillTable();
                    MessageBox.Show("Movie added!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Movie could not be added");
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Cancel movie entry? (Information will not be saved)", "Cancel",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
