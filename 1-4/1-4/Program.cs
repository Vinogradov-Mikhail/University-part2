using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_4
{
    class Program
    {
        const int n = 5;

        //print all array
        public static void PrintArray(int[,] array)
        {
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    System.Console.Write(array[i, j] + " ");
                }
                System.Console.WriteLine();
            }
        }

        //print array from mid fnd than print how snake
        public static void SnakePrint(int[,] array)
        {
            for (int k = n/2; k >=0; --k)
            {
                if (k > 0)
                {
                    for (int i = k; i <= n - k; ++i)
                        System.Console.Write(array[i, n - k - 1] + " ");
                    for (int j = n - k - 2; j >= k - 1; --j)
                        System.Console.Write(array[n - k, j] + " ");
                    for (int i = n - k - 1; i >= k - 1; --i)
                        System.Console.Write(array[i, k - 1] + " ");

                    for (int j = k ; j < n - k ; ++j)
                        System.Console.Write(array[k - 1, j] + " ");
                }
                else
                {
                    for (int i = k; i < n - k; ++i)
                        System.Console.Write(array[i, n - k - 1] + " ");
                }
            }

        }

        static void Main(string[] args)
        {
            //example of array
            int[,] array = { { 10, 20, 30, 40, 50}, { 60, 70, 80, 90, 10},{ 11, 12, 13, 14, 15}, { 15, 25, 35, 45, 55 }, { 66, 76, 86, 96, 106 } };
            //int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            PrintArray(array);
            SnakePrint(array);
        }
    }
}
