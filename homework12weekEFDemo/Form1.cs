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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static OrderService orderservice = new OrderService();
        public static List<OrderItem> items = new List<OrderItem>() {
                new OrderItem("1", "apple", 10.0, 20),
                new OrderItem("2", "egg", 2.0, 100)
            };
        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.Length != 0) && (textBox2.Text.Length == 0))
            {
                string id = textBox1.Text;
                Form1.orderservice.GetOrder(id);
                textBox2.Text = Form1.orderservice.GetOrder(id).Customer;
                if(Form1.orderservice.GetOrder(id) == null)
                {
                    MessageBox.Show("没找到该id!");
                }
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
    }
}
