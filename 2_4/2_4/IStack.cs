using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorNamespace
{
    /// <summary>
    /// interface for stack
    /// </summary>
    public interface IStack
    {
        /// <summary>
        /// add element in stack
        /// </summary>
        /// <param name="value"></param>
        void Push(int value);

        /// <summary>
        /// deletes last element and return its value.
        /// </summary>
        /// <returns></returns>
        int Pop();

        /// <summary>
        /// print all list
        /// </summary>
        void Print();
    }
} 
