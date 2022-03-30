namespace Assignment6
{
    public class Client
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
