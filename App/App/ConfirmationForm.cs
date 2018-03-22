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
        ManagerForm form;
        public ConfirmationForm(ManagerForm form, IQuery obj, string text)
        {
            this.obj = obj;
            this.form = form;
            InitializeComponent();
            label1.Text = text;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            DBEnvironment.Delete(obj);
            form.Reload(sender, e);
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
