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
            int id = int.Parse(s1);
            string customer = textBox2.Text;
            string commodity = textBox3.Text;
            Order order = new Order(id, customer, commodity);
            int i = Form1.orderservice.DeleteOrder(order);
            if (i == 0)
            {
                MessageBox.Show("该订单不存在!");
            }
            else
            {
                MessageBox.Show("删除成功!");
            }
        }
    }
}
