using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator3
{
    public partial class Form1 : Form
    {
        double num = 0;
        string operation = "";
        bool operation_clicked = false;


        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //number and decimal number button click
        private void button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();

            operation_clicked = false;

            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text += button.Text;
            }
            else
                textBox1.Text += button.Text;
        }

        private void pi_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "0") || (textBox1.Text == "0"))
                textBox1.Clear();

            textBox1.Text += "3.14159265359";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        //Math operator button clicked
        private void operator_Click(object sender, EventArgs e)
        {
            if(num != 0)
            {

            }
            else 
            { 
            Button button = (Button)sender;
            operation = button.Text;
            num = double.Parse(textBox1.Text);  //num is the first number in textBox1; double.Parse(textBox1.Text) is the second number in textBox1
            operation_clicked = true;
            if (operation_clicked)
                textBox1.Clear();
            }
        }

        private void button_equals_Click(object sender, EventArgs e)
        {

            switch(operation)
            {
                case "+":
                    textBox1.Text = (num + double.Parse(textBox1.Text)).ToString();
                    break;

                case "-":
                    textBox1.Text = (num - double.Parse(textBox1.Text)).ToString();
                    break;

                case "*":
                    textBox1.Text = (num * double.Parse(textBox1.Text)).ToString();
                    break;

                case "/":
                    textBox1.Text = (num / double.Parse(textBox1.Text)).ToString();
                    break;

                case "x^2":
                    textBox1.Text = (Math.Pow(num, 2)).ToString();
                    break;

                case "x^3":
                    textBox1.Text = (Math.Pow(num, 3)).ToString();
                    break;

                case "sqrt":
                    textBox1.Text = Math.Sqrt(double.Parse(textBox1.Text)).ToString();
                    break;

                case "sin":
                    if (radians.Checked == true)
                    {
                        textBox1.Text = Math.Sin(double.Parse(textBox1.Text)).ToString();
                    }
                    else if(degrees.Checked == true)
                    {
                        textBox1.Text = Math.Sin(double.Parse(textBox1.Text) * (Math.PI)/180).ToString();
                    }
                    break;
                    
                case "cos":
                    if (radians.Checked == true)
                    {
                        textBox1.Text = Math.Cos(double.Parse(textBox1.Text)).ToString();
                    }
                    else if (degrees.Checked == true)
                    {
                        textBox1.Text = Math.Cos(double.Parse(textBox1.Text) * (Math.PI) / 180).ToString();
                    }
                    break;

                case "tan":
                    if (radians.Checked == true)
                    {
                        textBox1.Text = Math.Tan(double.Parse(textBox1.Text)).ToString();
                    }
                    else if (degrees.Checked == true)
                    {
                        textBox1.Text = Math.Tan(double.Parse(textBox1.Text) * (Math.PI) / 180).ToString();
                    }
                    break;

                default :
                    break;
            }
            num = Int32.Parse(textBox1.Text);
            operation = "";

        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.')
            {
                if (textBox1.Text.Contains('.'))
                {
                    e.Handled = true;
                }
            }
        }

        

        
    }
} 