using System;
using System.Collections;
using System.Collections.Generic;

namespace Assignment2
{
    class Program1
    {
        /* 
        Write a program to output all prime factors of user-specified data。
        */
        static void Main(string[] args)
        {
            int num = 0;
            Console.Write("input data: ");
            try
            {
                num = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid input!");
            }

            // Output all prime factors of user-specified data
            var result = new HashSet<int>();
            OutputPrimeFactor(num, result);
            Console.Write("All prime factors of the data are: ");
            foreach(int i in result)
            {
                Console.Write($"{i} ");
            }
        }

        private static void OutputPrimeFactor(int data, HashSet<int> list)
        {
            if (data < 1) return;
            int i = 2;
            while(data >= i * i)
            {
                if (data % i == 0)
                {
                    list.Add(i);
                    data /= i;
                }
                else i += 1;
            }
        }
    }


}
