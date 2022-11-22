namespace aman
{
    public partial class Form1 : Form
    {
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
            if (data == "aman" && dataid==5409)
            {
                MessageBox.Show("true");
                MessageBox.Show(dataid+"");
            }
            else
            {
                MessageBox.Show("false");
                
            }
            for(int i = 0; i < 3; i++)
            {
                MessageBox.Show("success!" + i);
            }
            try("")
        }
    }
}