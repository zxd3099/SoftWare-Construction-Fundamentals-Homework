using System;
using System.Collections.Generic;

namespace Assignment5
{
    class MainPrograme
    {
        static void Main(string[] args)
        {
            OrderService orderService = new OrderService();
            Random random = new Random();

            Client[] client = { new Client("zxd"), new Client("hxq"), new Client("cxq"),
                                new Client("lyf"), new Client("hza"), new Client("kps")};

            Goods[] goods = { new Goods("001", 45.2, "goods1"), new Goods("002", 53.2, "goods2"),
                              new Goods("003", 100.2, "goods3"), new Goods("004", 64, "goods4"),
                              new Goods("005", 32, "goods1"), new Goods("006", 84.25, "goods2")};

            try
            {
                for (int i = 1; i <= 15; i++)
                {
                    List<OrderDetails> orderDetails = new List<OrderDetails>();
                    orderDetails.Add(new OrderDetails(goods[random.Next(6)], i));
                    orderService.AddOrder(new Order(i.ToString(), client[random.Next(6)], orderDetails));
                }

                orderService.GetOrders().ForEach(o => Console.WriteLine(o.ToString()));
                Console.WriteLine();

                //Console.WriteLine(orderService.QueryById("1").ToString());
                //Console.WriteLine();

                //orderService.QueryByClient("zxd").ForEach(o => Console.WriteLine(o.ToString()));
                //Console.WriteLine();

                //orderService.QueryByName("goods2").ForEach(o => Console.WriteLine(o.ToString()));
                //Console.WriteLine();

                //orderService.QueryByAmount(100.2).ForEach(o => Console.WriteLine(o.ToString()));
                //Console.WriteLine();

                orderService.DelOrderById("2");

                orderService.Sort((o1, o2) => o1.OrderAmount.CompareTo(o2.OrderAmount));

                orderService.GetOrders().ForEach(o => Console.WriteLine(o.ToString()));
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
