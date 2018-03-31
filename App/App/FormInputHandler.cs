using System;
using System.Windows.Forms;

namespace App
{
    internal class FormInputHandler
    {

        public FormInputHandler()
        {

        }
        
        private bool doesNotContainSemiColonOrSingleQuote(string text)
        {
            if (text.Contains(";"))
            {
                MessageBox.Show("No ; you hacker");
                return false;
            }
            return true;
        }
        public bool checkNames(string name)
        {
            if (name == "")
            {
                MessageBox.Show("Names can't be blank");
                return false;
            }
            
            return doesNotContainSemiColonOrSingleQuote(name);
        }
        public bool CheckForNull(String boxEntry)
        {
            if(boxEntry == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool checkSIN (string text)
        {
            int n;
            if (text.Length != 9)
            {
                MessageBox.Show("SIN number wrong length");
                return false;
            }
               
            if (!int.TryParse(text, out n))
            {
                MessageBox.Show("SIN number contains a letter");
                return false;
            }
            return doesNotContainSemiColonOrSingleQuote(text);

        }
        public void HandleException(Exception Ex)
        {
            if (Ex is AccountTypeException)
            {
                MessageBox.Show("Choose an account type.");
                return;
            }
            if (Ex is PostalCodeException)
            {
                MessageBox.Show("Invalid postal code.");
                return;
            }
            else if (Ex is PhoneNumberException)
            {
                MessageBox.Show("Invalid Phone Number.");
                return;
            }
        }

    }
    
}