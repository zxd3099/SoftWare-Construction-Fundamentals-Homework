using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Assignment12
{
    public class Goods{
        public string GoodsID {get; set;}
        public string Name {get; set;}
        public double Price {get; set;}
        public Goods() { }
        public Goods( string name, double price)
        {

            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name}\tprice: ￥{Price}";
        }

        public override bool Equals(object obj)
        {
            Goods m = obj as Goods;
            return m != null  && m.Name == Name && m.Price == Price;

        }

        public override int GetHashCode()
        {
            int hashCode = 710445796;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Price.GetHashCode();
            return hashCode;
        }
    }
}
