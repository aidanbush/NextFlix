using System;
using System.Windows.Forms;

namespace App
{
    public partial class ActorAddEdit : Form
    {
        AddMovieForm parent;
        Actor actor;
        FormInputHandler validator;
        public ActorAddEdit(AddMovieForm parent, Actor actor)
        {
            this.parent = parent;
            this.actor = actor;
            validator = new FormInputHandler();
            InitializeComponent();
            if (actor == null)
                return;


            fillFormData();
            AddEdit.Text = "Edit";
        }

        private void fillFormData()
        {
            FirstNameBox.Text = actor.Name.FirstName;
            LastNameBox.Text = actor.Name.LastName;
            if (actor.Sex == "M")
                MaleRadio.Checked = true;
            else
                FemaleRadio.Checked = true;

            DateOfBirthBox.Text = actor.DateOfBirth.ToString("MM/dd/yyyy");
        }

        private bool Validate()
        {
            if (!validator.checkNames(FirstNameBox.Text))
                return false;

            if (!validator.checkNames(LastNameBox.Text))
                return false;

            if (!validator.checkDateOfBirth(DateOfBirthBox.Text))
                return false;
        
            if (!FemaleRadio.Checked && !MaleRadio.Checked)
            {
                MessageBox.Show("Please select a sex");
                return false;
            }
            return true;
        }
        private void AddEdit_Click(object sender, EventArgs e)
        {
            if (!Validate())
                return;

            UserName name = new UserName(this.FirstNameBox.Text, this.LastNameBox.Text);
            Actor newActor;
            if (FemaleRadio.Checked)
                //Need to fix on database, reinit constraint from G to F
                newActor = new Actor(name, "G", validator.getDBReadyDate(DateOfBirthBox.Text), "", "", "");
            else if (MaleRadio.Checked)
                newActor = new Actor(name, "M", validator.getDBReadyDate(DateOfBirthBox.Text), "", "", "");
            else
                return;

            if (actor == null)
                DBEnvironment.Add(newActor);
            else
            {
                newActor.Id = actor.Id;
                DBEnvironment.Edit(newActor);
            }
            
            parent.Reload();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void FirstNameBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void MaleRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (MaleRadio.Checked)
                FemaleRadio.Checked = false;
        }

        private void FemaleRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (FemaleRadio.Checked)
                MaleRadio.Checked = false;
        }
    }
}
