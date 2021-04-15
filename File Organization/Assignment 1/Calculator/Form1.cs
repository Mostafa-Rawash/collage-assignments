using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        
            public Form1()
        {
            InitializeComponent();
        }
        public string num1 = "";
        public string  num2 = "";
        string sign = "none";
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void num_1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void num_2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }
        private void num_3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }
        private void num_4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }
        private void num_5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }
        private void num_6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }
        private void num_7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }
        private void num_8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }
        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }
        private void delete_Click(object sender, EventArgs e)
        {
            textBox1.Text =  0.ToString();
        }
        private void num_0_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num2 = textBox1.Text;
            if (sign == "none") {
                textBox1.Text = num1;
            }
            if (sign == "sub"){
                textBox1.Text = (int.Parse(num1) - int.Parse(num2)).ToString();
            }
            if (sign == "div") {
                textBox1.Text = (int.Parse(num1) / int.Parse(num2)).ToString();
            } 
            if (sign == "mul") {
                textBox1.Text = (int.Parse(num1) * int.Parse(num2)).ToString();
            }
            if (sign == "plus") {
                textBox1.Text = (int.Parse(num1) + int.Parse(num2)).ToString();
            }
        }

        private void div_Click(object sender, EventArgs e)
        {
            num1 = textBox1.Text;
            textBox1.Text = "";
            sign = "div";
        }

        private void mul_Click(object sender, EventArgs e)
        {
            num1 = textBox1.Text;
            textBox1.Text = "";
            sign = "mul";
        }

        private void sub_Click(object sender, EventArgs e)
        {
            num1 = textBox1.Text;
            textBox1.Text = "";
            sign = "sub";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            num1 = textBox1.Text;
            textBox1.Text = "";
            sign = "plus";
        }
    }
}
