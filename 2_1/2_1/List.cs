using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class List
    {
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
        /// delete all list
        /// </summary>
        public void Pop()
        {
            while(list.ItIsNotFree())
            {
                list.RemoveAt(0);
            }
        }
        /// <summary>
        /// print all list
        /// </summary>
        public void Print()
        {
            if (list.ItIsNotFree())
            {
                list.ShowElement();
            }
            else Console.WriteLine(" List is empty");
        }

    }
}
