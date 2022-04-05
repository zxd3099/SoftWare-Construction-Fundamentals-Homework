using System;
using System.Windows.Forms;

namespace Assignment7
{
    public partial class Form2 : Form
    {
        private double th1 = 30;
        private double th2 = 20;
        private double per1 = 0.6;
        private double per2 = 0.7;
        private int n = 10;
        private double leng = 100;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = (Form1)this.Owner;
            form.n = n;
            form.th2 = th2 * Math.PI / 180;
            form.th1 = th1 * Math.PI / 180;
            form.per1 = per1;
            form.per2 = per2;
            form.leng = leng;
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string temp = textBox1.Text;
            if (temp != null && temp != "") Double.TryParse(temp, out leng);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string temp = textBox2.Text;
            if (temp != null && temp != "") Double.TryParse(temp, out per1);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string temp = textBox3.Text;
            if (temp != null && temp != "") Double.TryParse(temp, out per2);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string temp = textBox4.Text;
            if (temp != null && temp != "") Double.TryParse(temp, out th1);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string temp = textBox5.Text;
            if (temp != null && temp != "") Double.TryParse(temp, out th2);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            string temp = textBox6.Text;
            if (temp != null && temp != "") int.TryParse(temp, out n);
        }
    }
}
