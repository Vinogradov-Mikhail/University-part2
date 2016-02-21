using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_3
{
    class Program
    {
        // bubble sort
        public static void Bubble(int[] array)
        {
            for (int i = 0; i < array.Length; ++i)
            {
                for (int j = 0; j < array.Length - 1; ++j)
                {
                    if (array[j] > array[j + 1])
                    {
                        int change = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = change;
                    }
                }
            }
        }
        
        // funvtion for printing array
        public static void PrintArray(int[] array)
        {
            for(int i = 0; i < array.Length; ++i)
            {
                System.Console.WriteLine(array[i]+" ");
            }
        }

        static void Main(string[] args)
        {
            int[] array = { 1, 5, 32, 2, 8, 3, 1 };
            Bubble(array);
            PrintArray(array);
        }
    }
}
