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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1 = textBox1.Text;
            int id = int.Parse(s1);
            string customer = textBox2.Text;
            string commodity = textBox3.Text;
            Order order = new Order(id,customer,commodity);
            int i = Form1.orderservice.AddOrder(order);
            if (i == 0)
            {
                MessageBox.Show("添加成功!");
            }
            else
            {
                MessageBox.Show("该订单已经有了!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox1.DataBindings.Add("DataSource", this, "id", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            //textBox2.DataBindings.Add("DataSource", this, "customer", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            //textBox1.DataBindings.Add("DataSource", this, "commodity", false, DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}
