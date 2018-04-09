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
    public partial class EditAccountType : Form
    {
        public enum AccountType { Disabled, Limited, Bronze, Silver, Gold };
        private Customer user;
        private CustomerForm parent;
        private string type;
        public AccountType accountType;

        public EditAccountType(Customer CurrentUser, CustomerForm parentForm )
        {
            user = CurrentUser;
            parent = parentForm;
            type = user.GetAccountType();

            InitializeComponent();

            currentTypeLabel.Text = "Current account type: " + type;
            AccountTypeDetails currentDetails = new AccountTypeDetails(type);
            FillLabels(currentDetails);
            
        }

        private void FillLabels(AccountTypeDetails deets)
        {
            PriceLabel.Text = "Price: $" + deets.GetPrice() + " per month";
            MoviesAllowedLabel.Text = "Movies allowed at a time: " + deets.GetMoviesAllowed();
            RentalsAllowedLabel.Text = "Movies allowed per month: " + deets.GetRentalsAllowed();

        }

        private void IndexChosen(object sender, EventArgs e)
        {
            AccountTypeDetails selectedAccountDetails;
            if(AccountTypeBox.SelectedItem == null)
            {

            }
            string selection = AccountTypeBox.SelectedItem.ToString();

            switch (selection)
            {
                case ("Limited"):
                    selectedAccountDetails = new AccountTypeDetails("limited");
                    FillLabels(selectedAccountDetails);
                    break;
                case ("Bronze"):
                    selectedAccountDetails = new AccountTypeDetails("bronze");
                    FillLabels(selectedAccountDetails);
                    break;
                case ("Silver"):
                    selectedAccountDetails = new AccountTypeDetails("silver");
                    FillLabels(selectedAccountDetails);
                    break;
                case ("Gold"):
                    selectedAccountDetails = new AccountTypeDetails("gold");
                    FillLabels(selectedAccountDetails);
                    break;
            }
        }

        private void ChooseAccountButton_Click(object sender, EventArgs e)
        {
            if(AccountTypeBox.SelectedItem == null)
            {
                MessageBox.Show("Please select an account type!");
            }
            else
            {
                AccountTypeDetails selection = new AccountTypeDetails(AccountTypeBox.SelectedItem.ToString());
                if (user.UpdateAccount(selection.GetAccountType()))
                {
                    MessageBox.Show("Account updated, the changes will reflect on your next bill");
                }
                else
                {
                    MessageBox.Show("Could not be update, try again later");
                }
            }

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure you want to leave?", "Cancel",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                if (user.UpdateAccount("Disabled"))
                {
                    MessageBox.Show("Sorry to see you go");
                }
                else
                {
                    MessageBox.Show("YOU'LL NEVER LEAVE");
                }
            }
            this.Close();
        }
    }
}
