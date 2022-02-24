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
        double a = 0, b = 0, res = 0;
        string d;
        bool c = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "") a = 0;
            else a = Double.Parse(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (d)
            {
                case "+":
                    res = a + b;
                    break;
                case "-":
                    res = a - b;
                    break;
                case "*":
                    res = a * b;
                    break;
                case "/":
                    if (b != 0) res = a / b;
                    break;
            }
            textBox3.Text = res.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            d = "+";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            d = "-";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "") b = 0;
            else b = Double.Parse(textBox2.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            d = "*";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (b != 0)
            {
                d = "/";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
