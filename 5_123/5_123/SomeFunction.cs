using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_123
{
    /// <summary>
    /// class for function for list
    /// </summary>
    public class SomeFunction
    {
        /// <summary>
        /// function add element in new list use last list element with function
        /// </summary>
        /// <param name="list"></param>
        /// <param name="function"></param>
        /// <returns></returns>
        public List Map(List list, Func<int, int> function)
        {
            for(int i = 0; i < list.GetLength(); ++i)
            {
                list.InIndex(i, function(list.Pop(list.GetElement(i + 1))));
            }
            return list;
        }

        /// <summary>
        /// function add last element in new list if some function for element is true
        /// </summary>
        /// <param name="list"></param>
        /// <param name="function"></param>
        /// <returns></returns>
        public List Filter(List list, Func<int, bool> function)
        {
            List listTwo = new List();
            for (int i = 0; i < list.GetLength(); ++i)
            {
                if(function(list.GetElement(i + 1)))
                {
                    listTwo.Push(list.GetElement(i + 1));
                }
            }
            return listTwo;
        }

        /// <summary>
        /// fold function...............
        /// </summary>
        /// <param name="list"></param>
        /// <param name="start"></param>
        /// <param name="function"></param>
        /// <returns></returns>
        public int Fold(List list, int start, Func<int, int, int> function)
        {
            int operation = start * list.GetElement(1);
            for (int i = 1; i < list.GetLength(); ++i)
            {
                operation = function(operation, list.GetElement(i + 1));
            }
            return operation;
        }
    }
}
