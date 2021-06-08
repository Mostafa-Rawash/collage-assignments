using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace $safeprojectname$
{


    public partial class Form1 : Form
    {
        double num_1 = 0;
        double num_2 = 0;
        char operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void number_0_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("0"); // use .AppendText to add the number to richbox without deleting old data
        }

        private void number_1_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("1"); // use .AppendText to add the number to richbox without deleting old data
        }

        private void number_2_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("2");
        }

        private void number_3_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("3");
        }

        private void number_4_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("4");
        }

        private void number_5_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("5");
        }

        private void number_6_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("6");
        }

        private void number_7_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("7");
        }

        private void number_8_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("8");
        }

        private void number_9_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("9");
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (!richTextBox1.Text.Contains("."))
                richTextBox1.AppendText(".");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";   // use .Text  to delete all data in richbox 
        }

        private void div_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                num_1 = double.Parse(richTextBox1.Text);
                operation = '/';
                richTextBox1.Text = "";
            }
        }


        private void min_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                num_1 = double.Parse(richTextBox1.Text);
                operation = '-';
                richTextBox1.Text = "";
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "" )
            {
                num_1 = double.Parse(richTextBox1.Text);
                operation = '+';
                richTextBox1.Text = "";
            }
        }

        private void mul_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                num_1 = double.Parse(richTextBox1.Text);
                operation = '*';
                richTextBox1.Text = "";
            }
        }

        private void mud_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                num_1 = double.Parse(richTextBox1.Text);
                operation = '%';
                richTextBox1.Text = "";
            }
        }





        private void equal_Click(object sender, EventArgs e)
        {

            if (richTextBox1.Text != "")
            {
                if (num_1 != 0)  // to make sure if user enter first number first
                {

                    num_2 = double.Parse(richTextBox1.Text);
                    richTextBox1.Text = "";

                    if (operation == '+')
                    {

                        richTextBox1.Text = (num_1 + num_2).ToString();
                        num_1 = (num_1 + num_2);  // if user want to continue in prev. result
                        num_2 = 0;
                    }
                    else if (operation == '-')
                    {
                        richTextBox1.Text = (num_1 - num_2).ToString();
                        num_1 = (num_1 + num_2);  // if user want to continue in prev. result
                        num_2 = 0;
                    }
                    else if (operation == '/')
                    {
                        richTextBox1.Text = (num_1 / num_2).ToString();
                        num_1 = (num_1 + num_2);  // if user want to continue in prev. result
                        num_2 = 0;
                    }
                    else if (operation == '*')
                    {
                        richTextBox1.Text = (num_1 * num_2).ToString();
                        num_1 = (num_1 + num_2);  // if user want to continue in prev. result
                        num_2 = 0;
                    }
                    else if (operation == '%')
                    {
                        richTextBox1.Text = (num_1 % num_2).ToString();
                        num_1 = (num_1 + num_2);  // if user want to continue in prev. result
                        num_2 = 0;
                    }
                        
                    else MessageBox.Show("Please enter your operation");
                }
            }
            else MessageBox.Show("Please enter your operation ");  // because if user didn't enter the operation so num_1 still = 0



        }


    }
}
