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
        private ManagerForm parent;
        private Order order;

        public FufillOrderForm(ManagerForm newParent, Order newOrder)
        {
            parent = newParent;
            order = newOrder;
            InitializeComponent();
            FillForm();
        }

        private void FufillOrderButton_Click(object sender, EventArgs e)
        {
            if (DBEnvironment.FulfillOrder(order.Id, parent.User.Id))
            {
                // update parent table
                parent.FillTable();
            }
            Close();
        }

        private void FillForm()
        {
            Customer customer = DBEnvironment.GetCustomerByID(order.CustomerID);
            // get customer
            CustomerNameLabel.Text = "Name: " + customer.FirstName + " " + customer.LastName;
            StreetAddressLabel.Text = "Street Address: " + customer.StreetNumber;
            CityLabel.Text = "City: " + customer.City;
            ProvenceLabel.Text = "Provence: " + customer.Province;
            PostalCodeLabel.Text = "Postal Code: " + customer.PostalCode;
            PhoneLabel.Text = "Phone Number: " + customer.ContactInformation.PhoneNumber;
            EmailLabel.Text = "Email:" + customer.ContactInformation.Email;

            Movie movie = DBEnvironment.GetMovieByID(order.MovieID);
            // get movie
            MovieTitleLabel.Text = "Title: " + movie.Name;
            MovieIDLabel.Text = "Movie ID: " + movie.Id;
        }
    }
}
