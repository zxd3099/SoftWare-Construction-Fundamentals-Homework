using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Client
    {
        public string ClientName { get; set; }
        public Client() { }
        public Client(string name)
        {
            this.ClientName = name;
        }
        public override string ToString()
        {
            return $"{ClientName}";
        }
    }
}
