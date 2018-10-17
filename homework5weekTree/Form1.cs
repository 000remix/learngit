using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第五周__生成Cayley树
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.CreateGraphics();
            string s = textBox5.Text;
            int a = int.Parse(s);
            drawCayleyTree(a, 200, 310, 100, -Math.PI / 2);
            x = 1;
        }

        private Graphics graphics;
        double th1, th2;
        double per1,per2;
        int x;

        void drawCayleyTree(int n, double x0,double y0, double leng, double th)
        {
            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            double x2 = x0 + leng * Math.Cos(th)*0.8;
            double y2 = y0 + leng * Math.Sin(th)*0.5;

            switch (x)
            {
                case 1:
                    drawLine1(x0, y0, x1, y1, n);
                    break;
                case 2:
                    drawLine2(x0, y0, x1, y1, n);
                    break;

            }
            

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x2, y2, per2 * leng, th - th2);
        }
        
        void drawLine1(double x0, double y0, double x1, double y1, int width)
        {
            graphics.DrawLine(new Pen(Color.Pink, width),
                (int)x0, (int)y0, (int)x1, (int)y1);
        }

        void drawLine2(double x0, double y0, double x1, double y1, int width)
        {
            graphics.DrawLine(new Pen(Color.LightGray, width),
                (int)x0, (int)y0, (int)x1, (int)y1);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string s = textBox3.Text;
            double a = double.Parse(s);
            th2 = a * Math.PI / 180;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            double a = double.Parse(s);
            per1 = a;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.CreateGraphics();
            string s = textBox5.Text;
            int a = int.Parse(s);
            drawCayleyTree(a, 200, 310, 100, -Math.PI / 2);
            x = 2;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string s = textBox4.Text;
            double a = double.Parse(s);
            th1 = a * Math.PI / 180;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string s = textBox2.Text;
            double a = double.Parse(s);
            per2 = a;
        }
    }
}
