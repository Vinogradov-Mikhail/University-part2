using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorNamespace
{
    public interface IStack
    {
        /// <summary>
        /// add element in list
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
