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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-J0175O94;Initial Catalog=project;Integrated Security=True");
        DataSet ds = new DataSet();
        SqlDataAdapter sda;

        public Form1()
        {
            InitializeComponent();
            sda = new SqlDataAdapter("Select * From customer", con);

            sda.Fill(ds, "Customers");
            
            foreach (DataRow pRow in ds.Tables["Customers"].Rows)
            {
                Console.WriteLine(pRow["first_name"]);
            }

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Customers";
            con.Open();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void customerRepsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {


            String q = "insert into customer(first_name, last_name, account_type, creation_date, phone_number, email)" +
                "values (@first_name, @last_name, @account_type, @creation_date, @phone_number, @email)";

            using (SqlCommand command = new SqlCommand(q, con))
            {

                command.Parameters.AddWithValue("@first_name", "abc");
                command.Parameters.AddWithValue("@last_name", "abc");
                command.Parameters.AddWithValue("@creation_date", DateTime.Now);
                command.Parameters.AddWithValue("@account_type", "Limited");
                command.Parameters.AddWithValue("@phone_number", 7806679099);
                command.Parameters.AddWithValue("@email", "abc@gmaail.com");


                int err = command.ExecuteNonQuery();
                if (err < 0)
                {
                    Debug.Print("InserFailed");
                }
                sda.Fill(ds, "Customers");
                //dataGridView1.Rows.Clear();
                //dataGridView1.Refresh();

            }
        }
    }
}
