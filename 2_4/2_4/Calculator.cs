using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorNamespace
{
    /// <summary>
    /// calculator for two numbers. Numbers push in stack.
    /// </summary>
    public class Calculator
    {
        private IStack stack;

        /// <summary>
        /// constructor for calculator
        /// </summary>
        /// <param name="calc"></param>
        public Calculator(IStack calc)
        {
            stack = calc;
        }

        /// <summary>
        /// add element in stack
        /// </summary>
        /// <param name="value"></param>
        public void AddElement(int value)
        {
            stack.Push(value);
        }

        /// <summary>
        /// addition of two elements
        /// </summary>
        public void Addition()
        {
            int result = stack.Pop() + stack.Pop();
            stack.Push(result);
        }

        /// <summary>
        /// subtraction of elements
        /// </summary>
        public void Subtraction()
        {
            int result = stack.Pop() - stack.Pop();
            stack.Push(result);
        }

        /// <summary>
        /// multiply of elements
        /// </summary>
        public void Multy()
        {
            int result = stack.Pop() * stack.Pop();
            stack.Push(result);
        }

        /// <summary>
        /// divide of elements
        /// </summary>
        public void Divide()
        {
            int numOne = stack.Pop();
            int numTwo = stack.Pop();
            if(numTwo == 0)
            {
                Console.WriteLine("You can not do it!!!!!!!!!");
                return;
            }
            int result = numOne / numTwo;
            stack.Push(result);
        }

        /// <summary>
        /// print result of operation
        /// </summary>
        public int Result()
        {
            return stack.Pop();
        }
    }
}
