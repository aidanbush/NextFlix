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
    public partial class AddMovieForm : Form
    {
        ManagerForm parent;
        private BindingList<Actor> actors;
        private BindingList<Actor> movieActors;
        private BindingList<Actor> deletedActors;
        Actor selectedActor;
        Actor selectedActorInMovieList;
        Movie movie;
        public AddMovieForm(ManagerForm manager, Movie selectedMovie)
        {
            parent = manager;
            InitializeComponent();
            DBEnvironment.SetActors();
            actors = DBEnvironment.GetActors();
            movieActors = new BindingList<Actor>();
            deletedActors = new BindingList<Actor>();
            movie = selectedMovie;
            ActorList.DataSource = actors;
            MovieActorList.DataSource = movieActors;
            ActorList.AutoGenerateColumns = true;
            if (selectedMovie != null)
                fillForm();
        }

        private void fillForm()
        {
            CopyAmountBox.Text = movie.Num_copies.ToString();
            GenreBox.Text = movie.Genre;
            TitleBox.Text = movie.Name;
            FeesBox.Text = movie.Fees.ToString();
            AddMovieButton.Text = "Edit";
        }
        private bool InsertMovie()
        {
            if ((MessageBox.Show("Add new Movie with current information?", "Confirm",
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
                    newMovie.Id = -1;
                    DBEnvironment.Add(newMovie);
                    movie = newMovie;
                    
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

                if (movie != null)
                {

                    if (!EditMovie())
                    {
                        MessageBox.Show("There was a problem editing the movie");
                        return;
                    }
                    parent.FillTable();
                    MessageBox.Show("Movie Edited!");
                    this.Close();
                }
                else if (InsertMovie())
                {
                    if (!InsertActors(movie))
                    {
                        Debug.Print("There was a problem adding the actors");
                        return;
                    }
                    
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

        private bool EditMovie()
        {
            if ((MessageBox.Show("Add new Movie with current information?", "Confirm",
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
                    newMovie.Id = movie.Id;
                    DBEnvironment.Edit(newMovie);

                    Starred starred = new Starred(this.movieActors.ToArray(), deletedActors.ToArray(), newMovie);
                    DBEnvironment.Edit(starred);

                }
                catch(Exception e)
                {

                }
            }

            return true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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

        private void AddActor_Click(object sender, EventArgs e)
        {
            ActorAddEdit actorForm = new ActorAddEdit(this, null);
            actorForm.Show();
        }
        
        private void DeleteActor_Click(object sender, EventArgs e)
        {
            if (selectedActor == null)
                return;


            if ((MessageBox.Show("are you sure you want to delete" + selectedActor.Name.FirstName + "?", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {

                DBEnvironment.Delete(selectedActor);
                this.Reload();
            }
        }
        
        private void ActorList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {    
        }
        private void ActorList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            var index = ActorList.CurrentRow.Index;
            selectedActor = this.actors.ElementAt(index);
        }
        private bool InsertActors(Movie movie)
        {
                Starred s = new Starred(movieActors.ToArray(), null, movie);
                if (!DBEnvironment.Add(s))
                    return false;
            
            return true;
        }

        private void EditActor_Click(object sender, EventArgs e)
        {
            if (selectedActor == null)
                return;
            ActorAddEdit actorForm = new ActorAddEdit(this, selectedActor);
            actorForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedActor == null)
                return;

            if (movieActors.Contains(selectedActor))
                return;

            movieActors.Add(selectedActor);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (selectedActorInMovieList == null)
                return;

            if (!movieActors.Contains(selectedActorInMovieList))
                return;

            Debug.Print(selectedActorInMovieList.ToString());
            deletedActors.Add(selectedActorInMovieList);
            movieActors.Remove(selectedActorInMovieList);
        }
        
        public void Reload()
        {
            DBEnvironment.SetActors();
            actors = DBEnvironment.GetActors();
            ActorList.DataSource = actors;
            this.Refresh();
        }

        private void SelectActorInMovieList(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            var index = MovieActorList.CurrentRow.Index;
            selectedActorInMovieList = this.movieActors.ElementAt(index);
        }
    }
}
