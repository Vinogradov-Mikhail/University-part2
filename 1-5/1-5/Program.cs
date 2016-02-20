using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_5
{
    class Program
    {
        const int n = 2;
        const int m = 3;

        //bubble sort for column
        public static void bubble(int[,] array)
        {
            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < m - 1; ++j)
                {
                    if (array[0, j] > array[0, j + 1])
                    {
                        for (int k = 0; k < n; ++k)
                        {
                            int change = array[k, j];
                            array[k, j] = array[k, j + 1];
                            array[k, j + 1] = change;
                        }
                    }
                }
            }
        }

        //print all array
        public static void printArray(int[,] array)
        {
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    System.Console.Write(array[i, j] + " ");
                }
                System.Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[,] array = { { 9, 5, 32 } , { 8, 3, 1 } };
            bubble(array);
            printArray(array);
        }
    }
}