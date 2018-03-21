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
    public partial class ConfirmationForm : Form
    {
        IQuery obj;
        public ConfirmationForm(IQuery obj, string text)
        {
            this.obj = obj;
            InitializeComponent();
            label1.Text = text;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            DBEnvironment.Delete(obj);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
