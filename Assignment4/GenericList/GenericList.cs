using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_1
{
    class GenericListTest
    {
        static void Main(string[] args)
        {
            // Assign a random number to each node of the linked list
            int sum = 0;
            Random r = new Random();
            GenericList<int> list = new GenericList<int>();
            for(int i = 0; i < 10; i++)
            {
                list.Add(r.Next(1, 100));
            }
            int maxv = -1, minv = 105;
            list.ForEach(m => Console.WriteLine(m));
            list.ForEach(m => maxv = Math.Max(m, maxv));
            list.ForEach(m => minv = Math.Min(m, minv));
            list.ForEach(m => sum += m);
            Console.WriteLine($"Maximum value is {maxv}");
            Console.WriteLine($"Minimum value is {minv}");
            Console.WriteLine($"The sum is {sum}");

        }
    }
    
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }
        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        public GenericList()
        {
            head = tail = null;
        }
        public Node<T> Head { get => head; }
        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if(tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }

        }
        public void ForEach(Action<T> action)
        {
            for(Node<T> m = head; m.Next != null; m = m.Next)
            {
                action(m.Data);
            }
        }
    }
}
