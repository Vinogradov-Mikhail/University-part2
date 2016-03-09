using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorNamespace
{
    public class List : IStack
    {
        class ArrayList
        {
            private const int length = 50;
            private int[] arrayList = new int[length];

            /// <summary>
            /// count elemnts in array list
            /// </summary>
            private int count;

            /// <summary>
            /// constructor for ArrayList
            /// </summary>
            public ArrayList()
            {
                count = -1;
            }

            /// <summary>
            /// add element
            /// </summary>
            /// <param name="value"></param>
            public void Add(int value)
            {
                if (count < length)
                {
                    arrayList[++count] = value;
                }
            }

            /// <summary>
            /// check have list elements or no
            /// </summary>
            /// <returns></returns>
            public bool IsEmpty()
            {
                return count == -1;
            }

            /// <summary>
            /// show all elements
            /// </summary>
            public void ShowElement()
            {
                for (int i = 0; i <= count; ++i)
                {
                    Console.Write(arrayList[i] + " ");
                }
            }

            /// <summary>
            /// delete element from our position 
            /// </summary>
            /// <param name="index"></param>
            public int Pop()
            {
                if (count != -1)
                {
                    int tmp = arrayList[count];
                    --count;
                    return tmp;
                }
                return 0;
            }
        }

        /// <summary>
        /// list which element it is array
        /// </summary>
        private ArrayList list = new ArrayList();

        /// <summary>
        /// add element in list
        /// </summary>
        /// <param name="value"></param>
        public void Push(int value)
        {
            list.Add(value);
        }

        /// <summary>
        /// delete element from list
        /// </summary>
        public int Pop()
        {
            return list.Pop();
        }

        /// <summary>
        /// print all list
        /// </summary>
        public void Print()
        {
            if (!list.IsEmpty())
            {
                list.ShowElement();
            }
            else Console.WriteLine(" List is empty");
        }

    }
}
