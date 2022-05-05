using System.ComponentModel.DataAnnotations;

namespace Assignment12
{
    public class Client
    {
        [Key]
        public string Name {get; set;}
        public string VipShip {get; set;}
        public Client() { }
        public Client(string name,string vipship)
        {
            Name = name;
            VipShip = vipship;
        }
        public Client(string name)
        {
            Name = name;
            VipShip = "";
        }

        public override string ToString()
        {
            return $"{Name} {VipShip}";
        }
    }
}