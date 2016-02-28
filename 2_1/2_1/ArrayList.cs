using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class ArrayList
    {
        private static int length = 50;
        private int[] arrayList = new int[length];
        
        /// <summary>
        /// count elemnts in array list
        /// </summary>
        private int count;
        
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
        /// checking list is empty or not
        /// </summary>
        /// <returns></returns>
        public bool ItIsNotFree()
        {
            return (count != -1);
        }
        
        /// <summary>
        /// show all elements
        /// </summary>
        public void ShowElement()
        {
            for(int i = 0; i <= count; ++i)
            {
                Console.Write(arrayList[i] + " ");
            }
        }
        
        /// <summary>
        /// delete element from our position 
        /// </summary>
        /// <param name="index"></param>
        public void RemoveAt(int index)
        {
            if ((index >= 0) && (index <= count))
            {
                for (int i = index; i <= count; i++)
                {
                    arrayList[i] = arrayList[i + 1];
                }
                count--;
            }
        }
        
        /// <summary>
        /// get amount elements of list 
        /// </summary>
        /// <returns></returns>
        public int GetLength()
        {
            return count;
        }
    }
}
