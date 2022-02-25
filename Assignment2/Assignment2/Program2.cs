using System;

namespace Assignment2
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.Write("Input an integer array: ");
            string[] temp = Console.ReadLine().Split(' ');
            int[] array = new int[temp.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                try
                {
                    array[i] = int.Parse(temp[i]);
                }
                catch
                {
                    Console.WriteLine("Invalid input!");
                    System.Environment.Exit(0);
                }
            }
            int maxv, minv, sum;
            double meanv;
            Cal(array, out maxv, out minv, out meanv, out sum);
            Console.WriteLine($"max value is {maxv}, min value is {minv}, average value is {meanv}, sum is {sum}");
        }

        private static void Cal(int[] array, out int maxv, out int minv, out double meanv, out int sum)
        {
            maxv = int.MinValue;
            minv = int.MaxValue;
            sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                maxv = Math.Max(maxv, array[i]);
                minv = Math.Min(minv, array[i]);
                sum += array[i];
            }
            meanv = (double)sum / array.Length;
        }
    }
}
