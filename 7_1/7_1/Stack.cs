using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListNamespace
{
    public class Stack<T>
    {
        /// <summary>
        /// class for element of stack
        /// </summary>
        class Element
        {
            private T _value;
            private Element next;

            /// <summary>
            /// function for get or write value from element of stack
            /// </summary>
            public T Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                }
            }

            /// <summary>
            /// move to the next element of stack or get value of next element
            /// </summary>
            public Element Next
            {
                get
                {
                    return next;
                }
                set
                {
                    next = value;
                }
            }
        }
        private Element head = new Element();
        private int _count;

        /// <summary>
        /// stack constructor 
        /// </summary>
        public Stack()
        {
            _count = -1;
        }

        /// <summary>
        /// add element in stack
        /// </summary>
        /// <param name="value"></param>
        public void Push(T value)
        {
            if (_count == -1)
            {
                head.Value = value;
            }
            else
            {
                Element tmp = new Element();
                tmp.Value = value;
                tmp.Next = head;
                head = tmp;
            }
            ++_count;
        }

        /// <summary>
        /// delete first element
        /// </summary>
        public T Pop()
        {
            if (head == null)
            {
                throw new DoNotHaveElements("Stack is empty");
            }
            else
            {
                T swap = head.Value;
                head = head.Next;
                return swap;
            }
        }

        /// <summary>
        /// print all stack
        /// </summary>
        public void Print()
        {
            Element tmp = head;
            for (int i = 0; i <= _count; ++i)
            {
                Console.Write(tmp.Value + " ");
                tmp = tmp.Next;
            }
        }
    }
 }
