using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, res = 0;
            char op;
            Console.Write("Please input two numbers(Sample:2 3): ");
            string input = Console.ReadLine();
            string[] inputnum = input.Split(' ');
            a = Double.Parse(inputnum[0]);
            b = Double.Parse(inputnum[1]);
            Console.Write("Please input an operator(Sample: +): ");
            op = (char)Console.Read();
            switch (op) {
                case '+': res = a + b; break;
                case '-': res = a - b; break;
                case '*': res = a * b; break;
                case '/':
                    if (b == 0)
                    {
                        Console.WriteLine("The input is invalid!!");
                        System.Environment.Exit(0);
                    }
                    else res = a / b; 
                    break;
            }
            Console.WriteLine($"The calculation result is {res}");
        }
    }
}
