using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第五周_订单管理LINQ
{
    class Program
    {
        public class Order
        {
            public int ID, Sum;
            public string Customer, Commodity;
            public override string ToString()
            {
                return "ID: " + ID + "Customer: " + Customer + "Commodity: " + Commodity + "Sum: " + Sum;
            }
        }
        static List<Order> mList = new List<Order>();

        static void Main(string[] args)
        {
            mList.Add(new Order() { ID = 1, Customer = "小明", Commodity = "书", Sum = 12000 });
            var FindOrderByCommodity = from x in mList where x.Commodity == "书" select x;
            var FindOrderByCustomer = from y in mList where y.Customer  == "小明" select y;
            var FindOrderByID = from m in mList where m.ID == 1 select m;
            var FindOrderBySum = from n in mList where n.Sum > 10000 select n;
            foreach(var x in FindOrderByCommodity)
            {
                Console.WriteLine(x.ID + x.Customer + x.Commodity + x.Sum);
            }
            foreach (var x in FindOrderByCustomer)
            {
                Console.WriteLine(x.ID + x.Customer + x.Commodity + x.Sum);
            }
            foreach (var x in FindOrderByID)
            {
                Console.WriteLine(x.ID + x.Customer + x.Commodity + x.Sum);
            }
            foreach (var x in FindOrderBySum)
            {
                Console.WriteLine(x.ID + x.Customer + x.Commodity + x.Sum);
            }
        }
    }
}
