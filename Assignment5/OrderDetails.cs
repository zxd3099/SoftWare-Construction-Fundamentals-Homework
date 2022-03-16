using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class OrderDetails
    {
        public Goods OrderGoods { get; set; }
        public int Quantity { get; set; }
        public OrderDetails() { }
        public OrderDetails(Goods goods, int quantity)
        {
            this.OrderGoods = goods;
            this.Quantity = quantity;
        }

        public override bool Equals(object obj)
        {
            return obj is OrderDetails details &&
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
