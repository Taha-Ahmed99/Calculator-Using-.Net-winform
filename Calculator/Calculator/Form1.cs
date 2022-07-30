using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string a,Operator;
        double x, y;
        public Form1()
        {
            InitializeComponent();
        }
        void calculations()
        {
            y = Convert.ToDouble(textBox1.Text);
            if (Operator == "+")
            {
                textBox1.Text = Convert.ToString(x + y);
            }
            if (Operator == "-")
            {
                textBox1.Text = Convert.ToString(x - y);
            }
            if (Operator == "*")
            {

                textBox1.Text = Convert.ToString(x * y);
            }
            if (Operator == "/")
            {
                textBox1.Text = Convert.ToString(x / y);
            }
        }
        void input(int a)
        {
            if (textBox1.Text=="0")
            {
                this.textBox1.Text = Convert.ToString(a); 
            }
            else
            {
                textBox1.Text = textBox1.Text + a;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            calculations();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            x=Convert.ToDouble(textBox1.Text);
            this.textBox1.Text = "0";
            textBox1.Focus();
            Operator = "+";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            input(3);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            input(2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            input(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("."))
            {
                textBox1.Text = textBox1.Text;
                MessageBox.Show("More than 1 point is not allowed");
            }
            else
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            input(4);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            input(5);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            input(6);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            input(7);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            input(8);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            input(9);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            this.textBox1.Text = "0";
            Operator = "-";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            this.textBox1.Text = "0";
            Operator = "/";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            this.textBox1.Text="0";
            Operator = "*";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            a=textBox1.Text.Remove(textBox1.Text.Length - 1);
            textBox1.Text=a;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                a = "0";
            }
            else
            {
                a = textBox1.Text+"0";
            }
            textBox1.Text = a;
        }
    }
}
