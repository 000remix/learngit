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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1 = textBox1.Text;
            string pattern1 = "20((0[0-9])|(1[0-8]))((0[1-9])|(1[12]))(0[1-9]|[12][0-9]|30)[0-9]{3}";
            Int64 id1 = Int64.Parse(s1);
            string customer1 = textBox2.Text;
            string commodity1 = textBox3.Text;
            Order order1 = new Order(id1, customer1, commodity1);
            string s2 = textBox4.Text;
            Int64 id2 = Int64.Parse(s2);
            string customer2 = textBox5.Text;
            string commodity2 = textBox6.Text;
            Order order2 = new Order(id2, customer2, commodity2);
            int i = Form1.orderservice.ReviseOrder(order1,order2);
            string pattern2 = "[0-9]{7}";
            bool ok1 = Regex.IsMatch(s1, pattern1);
            bool ok2 = Regex.IsMatch(customer1, pattern2);
            bool ok3 = Regex.IsMatch(s2, pattern1);
            bool ok4 = Regex.IsMatch(customer2, pattern2);
            if (ok1 & ok2 & ok3 & ok4)
            {
                if (i == 0)
                {
                    MessageBox.Show("该订单不存在!");
                }
                else
                {
                    MessageBox.Show("修改成功!");
                }
            }
            else { MessageBox.Show("订单号或者客户电话号码不正确!"); }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
