using Microsoft.VisualStudio.TestTools.UnitTesting;
using 第六周_订单管理XML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第六周_订单管理XML.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        [TestMethod()]
        public void AddOrderTest()
        {
            OrderService orderservice = new OrderService();
            Order order = new Order(1, "小", "米");
            orderservice.AddOrder(order);
            Assert.IsTrue( orderservice.mList != null);
        }

        [TestMethod()]
        public void DeleteOrderTest()
        {
            OrderService orderservice = new OrderService();
            Order order = new Order(1, "小", "米");
            orderservice.AddOrder(order);
            orderservice.DeleteOrder(order);
            Assert.IsTrue(orderservice.mList == null);
        }

        [TestMethod()]
        public void ReviseOrderTest()
        {
            OrderService orderservice = new OrderService();
            Order order1 = new Order(1, "小", "米");
            Order order2 = new Order(2, "小", "米");
            orderservice.AddOrder(order1);
            orderservice.ReviseOrder(order1, order2);
            Assert.AreEqual(orderservice.mList[0].ID, order2.ID);
            Assert.AreEqual(orderservice.mList[0].Customer, order2.Customer);
            Assert.AreEqual(orderservice.mList[0].Commodity, order2.Commodity);
        }

        [TestMethod()]
        public void FindOrderTest()
        {
            OrderService orderservice = new OrderService();
            Order order = new Order(1, "小", "米");
            orderservice.AddOrder(order);
            Assert.IsTrue(orderservice.FindOrder(1));
        }

        [TestMethod()]
        public void ExportTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ImportTest()
        {
            Assert.Fail();
        }
    }
}