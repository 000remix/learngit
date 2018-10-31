using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            int id1 = int.Parse(s1);
            string customer1 = textBox2.Text;
            string commodity1 = textBox3.Text;
            Order order1 = new Order(id1, customer1, commodity1);
            string s2 = textBox4.Text;
            int id2 = int.Parse(s2);
            string customer2 = textBox5.Text;
            string commodity2 = textBox6.Text;
            Order order2 = new Order(id2, customer2, commodity2);
            int i = Form1.orderservice.ReviseOrder(order1,order2);
            if (i == 0)
            {
                MessageBox.Show("该订单不存在!");
            }
            else
            {
                MessageBox.Show("修改成功!");
            }
        }
    }
}
