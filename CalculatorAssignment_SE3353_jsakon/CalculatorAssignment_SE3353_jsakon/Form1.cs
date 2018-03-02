using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorAssignment_SE3353_jsakon
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        double num = 0;
        //string num2 = string.Empty;
        char opr;
        double ans = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 0;
            this.textBox1.Text += input;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 1;
            this.textBox1.Text += input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 2;
            this.textBox1.Text += input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 3;
            this.textBox1.Text += input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 4;
            this.textBox1.Text += input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 5;
            this.textBox1.Text += input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 6;
            this.textBox1.Text += input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 7;
            this.textBox1.Text += input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 8;
            this.textBox1.Text += input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 9;
            this.textBox1.Text += input;
        }

        private void add_Click(object sender, EventArgs e)
        {
            double num1;
            double.TryParse(input, out num1);
            opr = '+';
            if (ans == 0)
            {
                ans = num1;
                input = string.Empty;
            }
            else
            {
                ans = ans + num1;
                this.textBox1.Text = ans.ToString();
                input = string.Empty;
            }
        }

        private void sub_Click(object sender, EventArgs e)
        {
            double num1;
            double.TryParse(input, out num1);
            opr = '-';
            if (ans == 0)
            {
                ans = num1;
                input = string.Empty;
            }
            else
            {
                ans = ans - num1;
                this.textBox1.Text = ans.ToString();
                input = string.Empty;
            }
        }

        private void multi_Click(object sender, EventArgs e)
        {
            double num1;
            double.TryParse(input, out num1);
            opr = 'x';
            if (ans == 0)
            {
                ans = num1;
                input = string.Empty;
            }
            else
            {
                ans = ans * num1;
                this.textBox1.Text = ans.ToString();
                input = string.Empty;
            }
        }

        private void divide_Click(object sender, EventArgs e)
        {
            double num1;
            double.TryParse(input, out num1);
            opr = '/';
            if (ans == 0)
            {
                ans = num1;
                input = string.Empty;
            }
            else
            {
                ans = ans / num1;
                this.textBox1.Text = ans.ToString();
                input = string.Empty;
            }
        }

        private void inFix_Click(object sender, EventArgs e)
        {

        }

        private void postFix_Click(object sender, EventArgs e)
        {

        }

        private void equals_Click(object sender, EventArgs e)
        {
  
            double num1, num2;
            double.TryParse(input, out num1);

            if (opr == '+')
            {
                ans = ans + num1;
                textBox1.Text = ans.ToString();
                input = string.Empty;
            }
            else if (opr == '-')
            {
                ans = ans - num1;
                textBox1.Text = ans.ToString();
                input = string.Empty;
            }
            else if (opr == 'x')
            {
                ans = ans * num1;
                textBox1.Text = ans.ToString();
                input = string.Empty;
            }
            else if (opr == '/')
            {
                if (num1 != 0)
                {
                    ans = ans / num1;
                    textBox1.Text = ans.ToString();
                    input = string.Empty;
                }
                else
                {
                    textBox1.Text = "DIV/Zero!";
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void clr_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.ans = 0.0;

        }
    }
}
