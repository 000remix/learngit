using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第四周_订单管理
{
    public class Order
    {
        public int ID;
        public string Customer,Commodity;
        public Order(int x,string y,string z)
        {
            ID = x;
            Customer = y;
            Commodity = z;
        }
    }

    public class OrderService
    {
        List<Order> mList = new List<Order>();
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
            else {
                mList.RemoveAt(j);
                Console.WriteLine("删除成功!"); }
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

        public void FindOrder(int id)
        {
            int i = 0;
            foreach (Order o in mList)
            {
                if(id == o.ID)
                {
                    i++;
                    Console.WriteLine("ID:" + id + "CustomerName:" + o.Customer + "CommodityName:" + o.Commodity);
                }
            }
            if (i == 0)
            {
                Console.WriteLine("该订单不存在!");
            }
            else { Console.WriteLine("查找成功!"); }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            OrderService orderservice = new OrderService();
            Order order1 = new Order(1,"小","米");
            orderservice.AddOrder(order1);
            Order order2 = new Order(1, "小", "米");
            orderservice.DeleteOrder(order2);
            orderservice.AddOrder(order2);
            Order order3 = new Order(2, "小", "米");
            orderservice.AddOrder(order3);
            Order order4 = new Order(4, "小", "米");
            orderservice.AddOrder(order4);
            orderservice.FindOrder(2);
            orderservice.ReviseOrder(order3,order4);
        }
    }
}
