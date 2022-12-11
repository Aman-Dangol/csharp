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

        private void barsa_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void number_TextChanged(object sender, EventArgs e)
        {
        }

        private void insert_Click(object sder, EventArgs e)
        {
            
            withdb.Open();
            string query = "insert into details(name,age,contact) values ('"+naam.Text+ "','"+Convert.ToInt32(barsa.Text) + "','"+number.Text+"')";
            SqlCommand cmd= new SqlCommand(query, withdb);
            cmd.ExecuteNonQuery();
            string q = "select * from details";
            cmd= new SqlCommand(q, withdb);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            withdb.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int uid=Convert.ToInt32(textBox1.Text);
            withdb.Open();
            string query = "delete from details where id='"+ uid+"'";
           SqlCommand cmd = new SqlCommand(query, withdb);
           cmd.ExecuteNonQuery();
            string q = "select * from details";
            cmd = new SqlCommand(q,withdb);
            SqlDataAdapter ab= new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ab.Fill(dt);
            dataGridView1.DataSource= dt;
            MessageBox.Show("the id "+uid+" has been deleted");
            withdb.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            withdb.Open();
            int x=Convert.ToInt32(textBox2.Text);
            string se = "select * from details where id='" + textBox2.Text + "'";
            string query = "update details set name='"+textBox3.Text+"' , age='"+(textBox4.Text) +"',contact='"+textBox5.Text+"' where id='"+x+"'";
            SqlCommand cmd= new SqlCommand(query, withdb);
            cmd.ExecuteNonQuery();
             string q = "select * from details";
            cmd = new SqlCommand(q,withdb);
            SqlDataAdapter ab= new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ab.Fill(dt);
            dataGridView1.DataSource= dt;
            withdb.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var data = dataGridView1.CurrentRow;
            var id = data.Cells["id"].Value.ToString();
            var na=data.Cells["name"].Value.ToString();
            var ag= data.Cells["age"].Value.ToString();
            var c=data.Cells["contact"].Value.ToString();
            textBox2.Text=id;
            textBox3.Text=na;
            textBox4.Text=ag;
            textBox5.Text=c;
            int a = 99;
        }
    }
}
