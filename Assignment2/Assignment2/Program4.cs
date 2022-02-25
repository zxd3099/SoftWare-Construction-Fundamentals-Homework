using System;

namespace Assignment2
{
    class Program4
    {
        static void Main(string[] args)
        {
            Console.Write("Input the row num and the column num, Sample: 3 4 .");
            string[] tmp = Console.ReadLine().Split(' ');
            int m = 0, n = 0;
            try
            {
                m = int.Parse(tmp[0]);
                n = int.Parse(tmp[1]);
            }
            catch
            {
                Console.WriteLine("Invalid input!");
                System.Environment.Exit(0);
            }
            int[][] array = new int[m][];
            Console.WriteLine("Input the matrix: ");
            for (int i = 0; i < m; i++)
            {
                string[] temp = Console.ReadLine().Split(' ');
                if(temp.Length != n)
                {
                    Console.WriteLine("Invalid input!");
                    System.Environment.Exit(0);
                }
                array[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    try
                    {
                        array[i][j] = int.Parse(temp[j]);
                    }
                    catch                 
                    {
                        Console.WriteLine("Invalid input!");
                        System.Environment.Exit(0);
                    }
                }
                
            }
            if (IsToeplitzMatrix(array))
            {
                Console.WriteLine("The matrix is a toeplitz matrix.");
            }
            else
            {
                Console.WriteLine("The matrix is not a toeplitz matrix.");
            }
            
        }

        private static bool IsToeplitzMatrix(int[][] array)
        {
            int m = array.Length, n = array[0].Length;
            for (int i = 0; i < n; i++)
            {
                int j = 1;
                while(j < m && i + j < n)
                {
                    if (array[j][i + j] != array[0][i]) return false;
                    else j++;
                }
            }
            for (int j = 0; j < m; j++)
            {
                int i = 1;
                while (i < n && i + j < m)
                {
                    if (array[i + j][i] != array[j][0]) return false;
                    else i++;
                }
            }
            return true;
        }
    }
}
