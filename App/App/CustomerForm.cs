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
    public partial class CustomerForm : Form
    {
        private Form parent;
        private Customer user;

        private enum CustomerFormType { home, movie, rentals, profile };
        private CustomerFormType currentType;


        public CustomerForm(Form newParent, Customer newUser)
        {
            parent = newParent;
            user = newUser;

            currentType = CustomerFormType.home;
            InitializeComponent();
            HomePanel.Visible = true;
            ProfilePanel.Visible = false;
        }

        private void myMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void movieHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void myProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeFormType();
            currentType = CustomerFormType.profile;
            Console.WriteLine("Showing profile");
            ProfilePanel.Visible = true;  
        }

        private void ChangeFormType()
        {
            switch (currentType)
            {
                case (CustomerFormType.home):
                    HomePanel.Visible = false;
                    break;
                case (CustomerFormType.profile):
                    ProfilePanel.Visible = false;
                    break;
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeFormType();
            currentType = CustomerFormType.home;
            Console.WriteLine("Showing home");
            HomePanel.Visible = true;
        }

        private void HomePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CustomerFormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }
    }
}
