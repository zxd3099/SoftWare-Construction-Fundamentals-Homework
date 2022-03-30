using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{
    public class Order : IComparable<Order>
    {
        public Client OrderClient { get; set; }
        public List<OrderDetails> Detail { get; set; }
        public string OrderID { get; set; }
        public double OrderAmount
        {
            get
            {
                double res = 0;
                foreach (var d in Detail)
                {
                    res += d.Quantity * d.OrderGoods.Price;
                }
                return res;
            }
        }

        public Order() { }

        public Order(string orderID, Client orderClient, List<OrderDetails> detail)
        {
            OrderClient = orderClient;
            Detail = detail;
            OrderID = orderID;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder($"OrderId:{OrderID}, Client:{OrderClient}\nOrderDetails: ");
            foreach (var d in Detail)
            {
                stringBuilder.Append(d.ToString());
            }
            stringBuilder.Append($"Total Amount:{OrderAmount}");
            return stringBuilder.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   EqualityComparer<Client>.Default.Equals(OrderClient, order.OrderClient) &&
                   EqualityComparer<List<OrderDetails>>.Default.Equals(Detail, order.Detail) &&
                   OrderID == order.OrderID &&
                   OrderAmount == order.OrderAmount;
        }

        public override int GetHashCode()
        {
            int hashCode = -685548663;
            hashCode = hashCode * -1521134295 + EqualityComparer<Client>.Default.GetHashCode(OrderClient);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<OrderDetails>>.Default.GetHashCode(Detail);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(OrderID);
            hashCode = hashCode * -1521134295 + OrderAmount.GetHashCode();
            return hashCode;
        }

        public int CompareTo(Order other)
        {
            if (other == null) throw new ArgumentNullException();
            return this.OrderID.CompareTo(other.OrderID);
        }
    }
}
