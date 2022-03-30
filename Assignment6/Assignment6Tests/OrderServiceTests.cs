using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment6;
using System;
using System.Collections.Generic;
using System.IO;

namespace Assignment6.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        OrderService orderService = new OrderService();

        static Client client1 = new Client("xyf");
        static Client client2 = new Client("zzx");
        static Client client3 = new Client("lbr");

        static Goods goods1 = new Goods("1", 12, "哈利波特");
        static Goods goods2 = new Goods("2", 15, "理想国");
        static Goods goods3 = new Goods("3", 18, "百年孤独");


        static Order order1 = new Order("1", client1,  new List<OrderDetails> { new OrderDetails(goods1, 2) });
        static Order order2 = new Order("2", client1,  new List<OrderDetails> { new OrderDetails(goods2, 3) });
        static Order order3 = new Order("3", client2,  new List<OrderDetails> { new OrderDetails(goods3, 1) });
        static Order order4 = new Order("4", client2,  new List<OrderDetails> { new OrderDetails(goods3, 1), 
                new OrderDetails(goods1, 2) });
        static Order order5 = new Order("5", client3,  new List<OrderDetails> { new OrderDetails(goods1, 4),
                new OrderDetails(goods2, 2), new OrderDetails(goods3, 1) });


        [TestInitialize]
        public void Initialize()
        {
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.AddOrder(order5);
        }

        [TestCleanup]
        public void CleanUp()
        {
            orderService.RemoveAll();
        }

        [TestMethod()]
        public void AddOrderTest()
        {
            orderService.AddOrder(order3);
            orderService.AddOrder(order4);
            CollectionAssert.AreEquivalent(new List<Order> { order1, order2, order3, order4, order5}, orderService.GetOrders());
        }

        [TestMethod()]
        public void DelOrderByIdTest()
        {
            orderService.DelOrderById("1");
            orderService.DelOrderById("5");
            CollectionAssert.AreEquivalent(new List<Order> { order2 }, orderService.GetOrders());
        }

        [TestMethod()]
        public void ModifyOrderTest()
        {
            Order newOrder = new Order("1", new Client("zxd"), new List<OrderDetails> { new OrderDetails(goods3, 2) });
            orderService.ModifyOrder(newOrder);
            CollectionAssert.AreEquivalent(new List<Order> { newOrder, order2, order5}, orderService.GetOrders());
        }

        [TestMethod()]
        public void QueryByIdTest()
        {
            Order o = orderService.QueryById("1");
            Assert.AreEqual(order1, o);
        }

        [TestMethod()]
        public void QueryByClientTest()
        {
            var orderList = orderService.QueryByClient("xyf");
            CollectionAssert.AreEquivalent(new List<Order>{order2}, orderList);
        }

        [TestMethod()]
        public void QueryByNameTest()
        {
            var orderList = orderService.QueryByName("哈利波特");
            CollectionAssert.AreEquivalent(new List<Order> {order5 }, orderList);
        }

        [TestMethod()]
        public void QueryByAmountTest()
        {
            var orderList = orderService.QueryByAmount(0);
            CollectionAssert.AreEquivalent(new List<Order> { order1, order2, order5 }, orderList);
        }

        [TestMethod()]
        public void SortTest()
        {
            orderService.Sort((o1, o2) => o1.OrderAmount.CompareTo(o2.OrderAmount));
            CollectionAssert.AreEqual(new List<Order> { order1, order2, order5 }, orderService.GetOrders());
        }

        [TestMethod()]
        public void ExportTest()
        {
            string fileName = "OrderService";
            orderService.Export(fileName);
            Assert.IsTrue(File.Exists(fileName + ".xml"));
        }

        [TestMethod()]
        public void ImportTest()
        {
            string path = "OrderService.xml";
            orderService.Import(path);
            CollectionAssert.AreEquivalent(new List<Order> { order1, order2, order5 }, orderService.GetOrders());
        }
    }
}