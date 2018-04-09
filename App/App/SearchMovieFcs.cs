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
    public partial class SearchMovieForm : Form
    {
        CustomerForm parent;
        private BindingList<Actor> actors;
        private BindingList<Actor> movieActors;
        private BindingList<Actor> deletedActors;
        Actor selectedActor;
        Actor selectedActorInMovieList;

        public SearchMovieForm(CustomerForm manager)
        {
            parent = manager;
            InitializeComponent();
            DBEnvironment.SetActors();
            actors = DBEnvironment.GetActors();
            movieActors = new BindingList<Actor>();
            deletedActors = new BindingList<Actor>();
            ActorList.DataSource = actors;
            MovieActorList.DataSource = movieActors;
            ActorList.AutoGenerateColumns = true;
            MovieActorList.Columns["Id"].Visible = false;
            MovieActorList.Columns["Sex"].Visible = false;
            MovieActorList.Columns["DateOfBirth"].Visible = false;
            MovieActorList.Columns["Age"].Visible = false;
            MovieActorList.Columns["Rating"].Visible = false;

        }

        private bool CheckTextBoxes()
        {
            if (TitleBox.Text == "")
            {
                MessageBox.Show("Plese check the movie title and Copy amount");
                return false;
            }
            else if (TitleBox.Text == "")
            {
                MessageBox.Show("Please check the title");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ActorList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            var index = ActorList.CurrentRow.Index;
            selectedActor = this.actors.ElementAt(index);
            ActorList.Rows[index].Selected = true;
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
            MovieActorList.Rows[index].Selected = true;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            FormInputHandler inputcleaner = new FormInputHandler();
            
            List<String> queryList = new List<String>();

            if (!inputcleaner.doesNotContainSemiColonOrSingleQuote(TitleBox.Text))
                return;

            String q = "Select * from movie where [name] like '%" + TitleBox.Text + "%' ";

            if (GenreComboBox.Text != "")
                queryList.Add("genre like '" + GenreComboBox.Text + "'");

            if (movieActors.Count != 0)
            {
                string actors = "";
                foreach (Actor actor in movieActors)
                {
                    actors += actor.Id.ToString() + ", ";
                }
                //remove the last 2 characters
                actors = actors.Remove(actors.Length - 2);
                queryList.Add("mid in (select mid from starred where aid in ("+actors+"))");
                
            }
            
            foreach(string s in queryList)
            {
                q += "and " + s;
            }
            parent.fillSearch(DBEnvironment.searchForMovies(q));
        }
    }
}
