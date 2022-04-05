using System;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment7
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        public double th1 = 30 * Math.PI / 180;
        public double th2 = 20 * Math.PI / 180;
        public double per1 = 0.6;
        public double per2 = 0.7;
        public int n = 10;
        public double leng = 100;
        private Pen pen;

        public Form1()
        {
            InitializeComponent();
            pen = new Pen(Color.Blue);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.CreateGraphics();
            drawCayleyTree(n, this.Width / 2, this.Height * 4 / 5, leng, -Math.PI / 2);
        }

        void drawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }

        void drawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button1.BackColor = colorDialog1.Color;
                pen.Color = colorDialog1.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(graphics != null) graphics.Clear(Control.DefaultBackColor);
        }
    }
}
