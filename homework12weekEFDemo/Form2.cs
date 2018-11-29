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
            string id = textBox1.Text;
            string customer = textBox2.Text;
            Order order = new Order(id, customer, DateTime.Now, Form1.items);
            Form1.orderservice.Add(order);
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
