using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Data.Entity;

namespace 第七周_订单管理WinForm
{

    class Program
    {
        public class OrderDB : DbContext
        {
            public OrderDB() : base("OrderDataBase")
            {
            }
            public DbSet<Order> Order { get; set; }

            public DbSet<OrderItem> OrderItem { get; set; }

        }

        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            /*OrderService orderservice = new OrderService();
            Order order1 = new Order(1, "小", "米");
            orderservice.AddOrder(order1);
            Order order2 = new Order(1, "小", "米");
            orderservice.DeleteOrder(order2);
            orderservice.AddOrder(order2);
            Order order3 = new Order(2, "小", "米");
            orderservice.AddOrder(order3);
            Order order4 = new Order(4, "小", "米");
            orderservice.AddOrder(order4);
            orderservice.FindOrder(2);
            orderservice.ReviseOrder(order3, order4);

            //XML序列化
            XmlSerializer xmlser = new XmlSerializer(typeof(List<Order>));
            string xmlFileName = "s.xml";
            orderservice.Export(xmlser, xmlFileName, orderservice);

            //显示XML文本
            string xml = File.ReadAllText(xmlFileName);
            Console.WriteLine(xml);

            orderservice.Import(xmlFileName);*/
        }
    }
}
