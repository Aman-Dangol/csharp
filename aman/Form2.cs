using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aman
{
    public partial class dbtry : Form
    {
        string username, aged, phone;

        SqlConnection withdb = new SqlConnection(
        @"data source=.\SQLEXPRESS;
        initial catalog=info;
        user id=sa;
        password=qwe;");

        public dbtry()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dbtry_Load(object sender, EventArgs e)
        {
            withdb.Open();
            string view = "select * from details";
            SqlCommand SqlCommand = new SqlCommand(view, withdb);
            SqlDataAdapter ab= new SqlDataAdapter(SqlCommand);
            DataTable information = new DataTable();
            ab.Fill(information);
            dataGridView1.DataSource= information;
            withdb.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            username = naam.Text;
        }
    }
}
