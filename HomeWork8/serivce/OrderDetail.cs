using System.Collections.Generic;

namespace Service
{
    public class OrderDetail
    {
        public Goods OrderGoods { get; set; }
        public int Quantity { get; set; }
        public double Money { get => Quantity * OrderGoods.Price; }
        public OrderDetail() { }
        public OrderDetail(Goods goods, int quantity)
        {
            this.OrderGoods = goods;
            this.Quantity = quantity;
        }

        public override bool Equals(object obj)
        {
            return obj is OrderDetail details &&
                   EqualityComparer<Goods>.Default.Equals(OrderGoods, details.OrderGoods) &&
                   Quantity == details.Quantity;
        }

        public override int GetHashCode()
        {
            int hashCode = -68924513;
            hashCode = hashCode * -1521134295 + EqualityComparer<Goods>.Default.GetHashCode(OrderGoods);
            hashCode = hashCode * -1521134295 + Quantity.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return OrderGoods.ToString() + $"{Quantity}\n";
        }
    }
}
