using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第七周_订单管理WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static OrderService orderservice = new OrderService();
        private void button1_Click(object sender, EventArgs e)
        {
            string pattern = "20((0[0-9])|(1[0-8]))((0[1-9])|(1[12]))(0[1-9]|[12][0-9]|30)[0-9]{3}";
            string s1 = textBox1.Text;
            if (s1 != "")
            {
                bool ok = Regex.IsMatch(s1, pattern);
                if (ok)
                {
                    Int64 id = Int64.Parse(s1);
                    int i = orderservice.FindOrder(id);
                    if (i == 0)
                    {
                        MessageBox.Show("订单不存在!");
                    }
                    else
                    {
                        textBox2.Text = orderservice.mList[i - 1].Customer;
                        textBox3.Text = orderservice.mList[i - 1].Commodity;
                    }
                }
                else { MessageBox.Show("订单号格式不正确!"); }
               
            }
            else
            {
                MessageBox.Show("订单号不能为空!");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
