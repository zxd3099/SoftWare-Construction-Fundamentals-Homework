using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment12
{
    public class Order : IComparable
    {
        public string OrderID{get; set;}
        public string ClientID {get; set;}
        public Client OrderClient{get; set;}
        public DateTime OrderTime{get; set;}
        public List<OrderDetail> OrderDetails{get; set;}
        public string DeliveryAddress{get; set;}
        public double TotalMoney{
            get {
                double sum = 0.0;
                if(OrderDetails != null)
                {
                    foreach(OrderDetail o in OrderDetails)
                        sum += o.Money;                   
                }
                return sum;
            }
        }
        public Order() {
            OrderClient = new Client();
            OrderDetails = new List<OrderDetail>();
        }
        public Order(string orderId,Client client,DateTime orderTime,string deliveryAddress,params OrderDetail[] orderDetails)
        {
            OrderID = orderId;
            OrderClient = client;
            OrderTime = orderTime;
            DeliveryAddress = deliveryAddress;
            OrderDetails = new List<OrderDetail>(orderDetails);
        }
        public void AddDetail(OrderDetail orderDetail)
        {
            if (OrderDetails.Contains(orderDetail))
                throw new ArgumentException($"添加错误：订单项{orderDetail.OrderGoods.Name} 已经存在!");
            OrderDetails.Add(orderDetail);
        }
        public override string ToString()
        {
            StringBuilder description = new StringBuilder( $"OrderId: {OrderID}\tOrderClient: {OrderClient}\tOrderTime: {OrderTime}\nOrderDetails: \n");
            //列出每条订单明细的信息
            foreach(OrderDetail o in OrderDetails)
                description.Append($"{o}\n");

            description.Append($"TotalMoney: {TotalMoney}\tDeliveryAdderss: {DeliveryAddress}");
            return description.ToString();
                
        }
        public override bool Equals(object obj)
        {
            Order o = obj as Order;
            return o != null && OrderID == o.OrderID;
        }

        public override int GetHashCode()
        {
            return 1651275338 + EqualityComparer<string>.Default.GetHashCode(OrderID);
        }
        public int CompareTo(object obj)
        {
            Order o = obj as Order;
            if (o == null)
                throw new ArgumentException();
            return this.OrderID.CompareTo(o.OrderID);
        }
    }
}
