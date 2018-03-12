using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
            dataGridView1.DataMember = "Customers";
            dataGridView1.DataSource = DBEnvironment.getDataSet();
            dataGridView1.AutoGenerateColumns = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            //dataGridView1.DataSource = DBEnvironment.getDataSet();
            AddCustomerForm AddUserForm = new AddCustomerForm();
            AddUserForm.Show();
            dataGridView1.Refresh();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {


            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DBEnvironment.UpdateRatings();
            // reload view
            Debug.Write("Updated Ratings");
        }
    }
}
