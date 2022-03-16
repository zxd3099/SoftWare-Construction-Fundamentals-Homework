using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class OrderService
    {
        private List<Order> orders = new List<Order>();

        public void AddOrder(Order order)
        {
            if(order == null || order.Detail.Count == 0)
            {
                throw new ArgumentException("Invalid input!");
            }
            if((from o in orders where o.OrderID == order.OrderID select o).Any())
            {
                throw new ArgumentException("The Order has already existed!");
            }
            orders.Add(order);
        }

        public void DelOrderById(string orderId)
        {
            var order = (from o in orders where o.OrderID == orderId select o).FirstOrDefault();
            if (order == null) throw new ArgumentException("Order does not exist!");
            orders.Remove(order);
        }

        public void ModifyOrder(Order newOrder)
        {
            if (newOrder == null || newOrder.Detail.Count == 0)
            {
                throw new ArgumentException("Invalid input!");
            }
            var order = (from o in orders where o.OrderID == newOrder.OrderID select o).FirstOrDefault();
            if (order == null) throw new ArgumentException("Order does not exist!");
            order.OrderClient = newOrder.OrderClient;
            order.Detail = newOrder.Detail;
        }
        public Order QueryById(string orderId)
        {
            var order = (from o in orders where o.OrderID == orderId select o).FirstOrDefault();
            if (order == null) throw new ArgumentException("Order does not exist!");
            return order;
        }
        public List<Order> QueryByClient(string clientName)
        {
            var order = from o in orders where o.OrderClient.ClientName == clientName select o;
            if(order == null) throw new ArgumentException("Order does not exist!");
            return order.ToList();
        }
        public List<Order> QueryByName(string orderName)
        {
            var order = from o in orders where
                            (from d in o.Detail where d.OrderGoods.GoodName == orderName select d).Any()
                            select o;
            if (order == null) throw new ArgumentException("Order does not exist!");
            return order.ToList();
        }
        public List<Order> QueryByAmount(double amount)
        {
            var order = from o in orders where o.OrderAmount == amount select o;
            if (order == null) throw new ArgumentException("Order does not exist!");
            return order.ToList();
        }
        public List<Order> GetOrders()
        {
            return orders;
        }
        public void Sort(Comparison<Order> comparison = null)
        {
            if (comparison == null) orders.Sort();
            else orders.Sort(comparison);
        }

    }
}
