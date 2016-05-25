using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2
{
    /// <summary>
    /// generic class for list
    /// </summary>
    public class List<T>
    {
        /// <summary>
        /// class for element of stack
        /// </summary>
        class Element
        {
            public T Value { get; set; }
            public Element Next { get; set; }

            /// <summary>
            /// constructor for stack element
            /// </summary>
            /// <param name="_value"></param>
            /// <param name="next"></param>
            public Element(T value)
            {
                this.Value = value;
            }
        }
        private Element head;// new Element(null, null);
        private int _count;

        /// <summary>
        /// constructor
        /// </summary>
        public List()
        {
            _count = -1;            
        }

        /// <summary>
        /// get length of list
        /// </summary>
        /// <returns></returns>
        public int Length()
        {
            return _count + 1;
        }

        /// <summary>
        /// add element in stack
        /// </summary>
        /// <param name="value"></param> 
        public void Push(T value)
        {
            var temp = new Element(value);
            if (_count == -1)
            {
                head = temp;
            }
            else
            {
                temp.Next = head;
                head = temp;
            }
            ++_count;
        }

        /// <summary>
        /// delete element from list
        /// </summary>
        /// <returns></returns>
        public T Pop(T elem)
        {
            if (head == null)
                throw new DoNotHaveElements("List is empty");
            if (head.Value.Equals(elem))
            {
                T tmp = head.Value;
                head = head.Next;
                --_count;
                return tmp;
            }
            Element temp = head;
            Element secondTemp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
                if (temp.Value.Equals(elem))
                {
                    secondTemp.Next = temp.Next;
                    --_count;
                    return temp.Value;
                }
                secondTemp = temp;
            }
            throw new NotFoundElement("Not found");
        }

        /// <summary>
        /// get element from position
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T GetElement(int index)
        {
            Element temp = head;
            for (int i = 0; temp.Next != null & i < index - 1; ++i)
            {
                temp = temp.Next;
            }
            return temp.Value;
        }

        /// <summary>
        /// print all stack
        /// </summary>
        public void Print()
        {
            Element tmp = head;
            while (tmp != null)
            {
                Console.Write(tmp.Value + " ");
                tmp = tmp.Next;
            }
        }

        /// <summary>
        /// find element in list
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public bool Find(T element)
        {
            Element tmp = head;
            while(tmp != null)
            {
                if (tmp.Value.Equals(element))
                {
                    return true;
                }
                tmp = tmp.Next;
            }
            return false;
        }

    }
}
