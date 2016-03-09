using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator(new Stack());// or use "new List()"
            calc.AddElement(5);
            calc.AddElement(9);
            calc.Divide();
            Console.WriteLine(calc.Result());
        }
    }
}
