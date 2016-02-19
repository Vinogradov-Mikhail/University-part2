using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialNumber
{
    class Program
    {
        public static int Factorial(int number) // function for make factorila number
        {
            if (number == 1)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("Write number");
            int number = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Your result = "+Factorial(number));
        }
    }
}
