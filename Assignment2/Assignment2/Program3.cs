using System;

namespace Assignment2
{
    class Program3
    {
        static void Main2(string[] args)
        {
            // if i is a prime, then array[i] = false, else array[i] = true.
            bool[] array = new bool[101];
            array[0] = array[1] = true;
            array[2] = false;
            FindPrime(array);
            Console.WriteLine("All prime numbers between 2-100 are: ");
            for(int i = 2; i <= 100; i++)
            {
                if (!array[i]) Console.Write($"{i} ");
            }
        }

        private static void FindPrime(bool[] array)
        {
            int t = 2, len = array.Length;
            while (t * t <= len)
            {
                for (int i = t + 1; i <= len; i++)
                {
                    // i is not a prime, so array[i] = true.
                    if (i % t == 0) array[i] = true;
                }
                for (int i = t + 1; i <= len; i++)
                {
                    if (!array[i])
                    {
                        t = i; break;
                    }
                }
            }
        }
    }
}
