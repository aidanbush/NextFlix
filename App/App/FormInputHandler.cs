using System;
using System.Windows.Forms;

namespace App
{
    internal class FormInputHandler
    {

        public FormInputHandler()
        {

        }
        
        private bool doesNotContainSemiColon(string text)
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
                MessageBox.Show("The customer's name cannon be blank");
                return false;
            }

            return doesNotContainSemiColon(name);
        }
        
    }
    
}