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
    public partial class FufillOrderForm : Form
    {
        private Form parent;
        private Order order;

        public FufillOrderForm(Form newParent, Order newOrder)
        {
            parent = newParent;
            order = newOrder;
            InitializeComponent();
        }

        private void FufillOrderButton_Click(object sender, EventArgs e)
        {
            // create report
            // add employee id
            // close form
            Close();
        }

        private FufillOrderForm()
        {
            // get customer
            CustomerNameLabel.Text = "Name: ";
            StreetAddressLabel.Text = "Street Address: ";
            CityLabel.Text = "City: ";
            ProvenceLabel.Text = "Provence: ";
            PostalCodeLabel.Text = "Postal Code: ";
            PhoneLabel.Text = "Phone Number: ";
            EmailLabel.Text = "Email:";

            // get movie
            MovieTitleLabel.Text = "Title: ";
            MovieIDLabel.Text = "Movie ID: ";
        }
    }
}
