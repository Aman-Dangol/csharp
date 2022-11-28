using System.Data.SqlClient;

namespace aman
{
    public partial class Form1 : Form
    {
        SqlConnection conn= new SqlConnection(
            @"data source=.\SQLEXPRESS;
            Initial catalog=bit3rdsem;
            user id=sa;
            password=aman;");
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string data = username.Text;
            int dataid = Convert.ToInt32(id.Text);
            if (data == "aman" && dataid == 5409)
            {
                MessageBox.Show("true");
                MessageBox.Show(dataid + "");
            }
            else
            {
                MessageBox.Show("false");

            }
            for (int i = 0; i < 3; i++)
            {
                MessageBox.Show("success!" + i);
            }

        }


        private void setdata_Click(object sender, EventArgs e)
        {
            username.Text = "Aman Dangol";
            id.Text = "5004";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            conn.Open();
            string query = "insert student( name,address,contact,phone)values ('kist','kamalpokhari','kist@gmail.com',1000)";
            SqlCommand cmd = new SqlCommand(query, conn); 
            cmd.ExecuteNonQuery();
            MessageBox.Show("successfully done");
            conn.Close();
        }
    }
}