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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //creates a new form and adds it to navigation
            FormNavigator.AddForm(new Form2(), "customersView");

            //navigates to the selected form
            FormNavigator.ChangeForm(this, "customersView");
        }
    }
}
