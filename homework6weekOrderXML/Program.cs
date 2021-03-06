﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace 第六周_订单管理XML
{
    public class Order
    {
        public int ID;
        public string Customer, Commodity;
        public Order() { }
        public Order(int x, string y, string z)
        {
            ID = x;
            Customer = y;
            Commodity = z;
        }
    }

    public class OrderService
    {
        public List<Order> mList = new List<Order>();
        public void AddOrder(Order order)
        {
            int i = 0;
            foreach (Order o in mList)
            {
                if (o.ID == order.ID && o.Customer == order.Customer && o.Commodity == order.Commodity)
                {
                    i++;
                }
            }
            if (i == 0)
            {
                mList.Add(order);
                Console.WriteLine("添加成功!");
            }
            else { Console.WriteLine("该订单已经有了!"); }
        }

        public void DeleteOrder(Order order)
        {
            int i = 0;
            int j = 0;
            foreach (Order o in mList)
            {
                if (o.ID == order.ID && o.Customer == order.Customer && o.Commodity == order.Commodity)
                {
                    j = i;
                    i++;
                }
            }
            if (i == 0)
            {
                Console.WriteLine("该订单不存在!");
            }
            else
            {
                mList.RemoveAt(j);
                Console.WriteLine("删除成功!");
            }
        }

        public void ReviseOrder(Order order1, Order order2)
        {
            int i = 0;
            foreach (Order o in mList)
            {
                if (o.ID == order1.ID && o.Customer == order1.Customer && o.Commodity == order1.Commodity)
                {
                    o.ID = order2.ID;
                    o.Customer = order2.Customer;
                    o.Commodity = order2.Commodity;
                    i++;
                }
            }
            if (i == 0)
            {
                Console.WriteLine("该订单不存在!");
            }
            else { Console.WriteLine("修改成功!"); }
        }

        public bool FindOrder(int id)
        {
            int i = 0;
            foreach (Order o in mList)
            {
                if (id == o.ID)
                {
                    i++;
                    Console.WriteLine("ID:" + id + "CustomerName:" + o.Customer + "CommodityName:" + o.Commodity);
                }
            }
            if (i == 0)
            {
                Console.WriteLine("该订单不存在!");
                return false;
            }
            else { Console.WriteLine("查找成功!");
                return true;
            }
        }

        public void Export(XmlSerializer ser, string filename, object obj)
        {
            FileStream fs = new FileStream(filename, FileMode.Create);
            ser.Serialize(fs, mList);
            fs.Close();
        }

        public void Import(string filename)
        {
            XElement o = XElement.Load(filename);
            var elements = from ele in o.Elements()
                           select ele;
            List<Order> orderlList = new List<Order>();
            foreach (var ele in elements)
            {
                Order order = new Order();
                order.ID = Convert.ToInt32(ele.Element("ID").Value);
                order.Customer = ele.Element("Customer").Value;
                order.Commodity = ele.Element("Commodity").Value;
                orderlList.Add(order);
                Console.WriteLine("载入订单成功");
            }
            orderlList.Add(new Order());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            OrderService orderservice = new OrderService();
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

            orderservice.Import(xmlFileName);
        }
    }
}
