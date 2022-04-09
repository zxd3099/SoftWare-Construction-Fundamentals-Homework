using System.Collections.Generic;

namespace Service
{
    public class Goods
    {
        public string GoodID { get; set; }
        public double Price { get; set; }
        public string GoodName { get; set; }
        public Goods() { }
        public Goods(string id, string name, double price)
        {
            this.GoodID = id;
            this.Price = price;
            this.GoodName = name;
        }

        public override string ToString()
        {
            return $"{GoodID}: {GoodName}, ￥{Price}, ";
        }

        public override bool Equals(object obj)
        {
            return obj is Goods goods &&
                   GoodID == goods.GoodID &&
                   Price == goods.Price &&
                   GoodName == goods.GoodName;
        }

        public override int GetHashCode()
        {
            int hashCode = -1881781494;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GoodID);
            hashCode = hashCode * -1521134295 + Price.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GoodName);
            return hashCode;
        }
    }
}
