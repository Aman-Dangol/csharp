using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aman
{
   
    public partial class calculator : Form
    {
        string op = "",x="";
        decimal res=0,a=0,b=0;
        public calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            tb.Text = tb.Text + "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
           
            tb.Text= tb.Text + "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
           
            tb.Text = tb.Text + "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
           
            tb.Text = tb.Text + "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            
            tb.Text = tb.Text + "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            
            tb.Text = tb.Text + "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
             
            tb.Text = tb.Text + "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            
            tb.Text = tb.Text + "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            
            tb.Text = tb.Text + "9";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            
            tb.Text = tb.Text+"0";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            tb.Text = "";
            a = 0;
            b = 0;
            x = "";
            eqn.Clear();
        }

        private void divide_Click(object sender, EventArgs e)
        {
            eqn.Clear();
            a = Convert.ToDecimal(tb.Text);
            op = "/";
            tb.Text += "/";
            tb.Text = "";
            eqn.Text += a + op;
        }

        private void mul_Click(object sender, EventArgs e)
        {
            eqn.Clear();
            a = Convert.ToDecimal(tb.Text);
            op = "*";
            tb.Text += "*";
            tb.Text = "";
            eqn.Text += a + op;
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void eqn_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           this.Hide();
            Form1 fm = new Form1();
            fm.ShowDialog();
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void plus_Click(object sender, EventArgs e)
        {
            //eqn.Clear();
            a =Convert.ToDecimal(tb.Text);            
            op = "+";
            tb.Text += "+";
            tb.Text = "";
            eqn.Text += a + op;

        }

        private void subtract_Click(object sender, EventArgs e)
        {
            eqn.Clear();
            a = Convert.ToDecimal(tb.Text);
            op="-";
            tb.Text += "-";
            tb.Text = "";
            eqn.Text += a + op;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            b=Convert.ToDecimal(tb.Text); 
            eqn.Text += b;
            switch (op)
            {
                case "+":
                    res = a + b;
                    tb.Text = Convert.ToString(res);
                    a = 0;
                    b = 0;
                    x = "";
                    
                    break;
                case "-":
                    res = a - b;
                    tb.Text = Convert.ToString(res);
                    a = 0;
                    b = 0;
                    x = "";
                    break;
                case "/":
                    if (b == 0)
                    {
                        MessageBox.Show("error! not divisible by zero");
                    }
                    else
                    {
                        res = a / b;
                    tb.Text = Convert.ToString(res);
                    }
                        
                    a = 0;
                    b = 0;
                    x = "";
                    break;
                case "*":
                    res = a * b;
                    tb.Text = Convert.ToString(res);
                    a = 0;
                    b = 0;
                    x = "";
                    break;

            }
        }
    }
}
