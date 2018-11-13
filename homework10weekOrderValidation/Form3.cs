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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1 = textBox1.Text;
            string pattern1 = "20((0[0-9])|(1[0-8]))((0[1-9])|(1[12]))(0[1-9]|[12][0-9]|30)[0-9]{3}";
            Int64 id = Int64.Parse(s1);
            string customer = textBox2.Text;
            string commodity = textBox3.Text;
            Order order = new Order(id, customer, commodity);
            int i = Form1.orderservice.DeleteOrder(order);
            string pattern2 = "[0-9]{7}";
            bool ok1 = Regex.IsMatch(s1, pattern1);
            bool ok2 = Regex.IsMatch(customer, pattern2);
            if (ok1&ok2)
            {
                if (i == 0)
                {
                    MessageBox.Show("订单不存在!");
                }
                else
                {
                    MessageBox.Show("删除成功!");
                }
            }
            else { MessageBox.Show("订单号或者客户电话号码不正确!"); }
        }
    }
}
