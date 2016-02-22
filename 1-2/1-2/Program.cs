using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumber
{
    class Program
    {
        // function for making factorial number
        public static int Factorial(int number)
        {
            if ((number == 1) || (number == 2))
            {
                return 1;
            }
            else
            {
                return Factorial(number - 2) + Factorial(number - 1);
            }
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("Write number");
            int number = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Your result = " + Factorial(number));
        }
    }
}