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
   
    public partial class form2 : Form
    {
        string op = "",x="";
        decimal res=0,a=0,b=0;
        public form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (x == "")
            {
                a = a*10+1;
                x = "1";
            }
            else
            {
                b = b * 10 + 1;
            }
            tb.Text = tb.Text + "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (x == "")
            {
                a = a * 10 + 2;
                x = "2";
            }
            else
            {
                b = b * 10 + 2;
            }
            tb.Text= tb.Text + "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (x == "")
            {
                x = "3";
                a = a * 10 + 3;
            }
            else
            {
                b = b * 10 + 3;
            }
            tb.Text = tb.Text + "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (x == "")
            {
                a = a * 10 + 4;
                x = "4";
            }
            else
            {
                b = b * 10 + 4;
            }
            tb.Text = tb.Text + "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (x == "")
            {
                a = a * 10 + 5;
                x = "5";
            }
            else
            {
                b = b * 10 + 5;
            }
            tb.Text = tb.Text + "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (x == "")
            {
                a = a*10+6;
                x = "6";
            }
            else
            {
                b = b * 10 + 6;
            }
            tb.Text = tb.Text + "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (x == "")
            {
                a = a * 10 + 7;
                x = "7";
            }
            else
            {
                b = b * 10 + 7;
            }
            tb.Text = tb.Text + "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (x == "")
            {
                a = a * 10 + 8;
                x = "8";
            }
            else
            {
                b = b * 10 + 8;
            }
            tb.Text = tb.Text + "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (x == "")
            {
                a = a * 10 + 9;
                x = "9";
            }
            else
            {
                b = b * 10 + 9;
            }
            tb.Text = tb.Text + "9";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (x == "")
            {
                a = a * 10 + 0;
            }
            else
            {
                b =b*10+0;
            }
            tb.Text = tb.Text+"0";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            tb.Text = "";
            a = 0;
            b = 0;
            x = "";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            op = "/";
            tb.Text += "/";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            
            op = "+";
            tb.Text += "+";

        }

        private void subtract_Click(object sender, EventArgs e)
        {
            op="-";
            tb.Text += "-";
        }

        private void equal_Click(object sender, EventArgs e)
        {
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
                    res = a b;
                    tb.Text = Convert.ToString(res);
                    a = 0;
                    b = 0;
                    x = "";
                    break;


            }
        }
    }
}
