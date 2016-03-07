using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorNamespace
{
    public class Stack : IStack
    {
        /// <summary>
        /// class for element of stack
        /// </summary>
        class Element
        {
            public int Value { get; set; }
            public Element Next { get; set; }

            /// <summary>
            /// constructor for stack element
            /// </summary>
            /// <param name="_value"></param>
            /// <param name="next"></param>
            public Element(int _value = 0, Element next = null)
            {
                this.Value = _value;
                this.Next = next;
            }
        }
        private Element head = null;// new Element();
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
        public void Push(int value)
        {
            head = new Element(value, head);
            ++_count;
        }

        /// <summary>
        /// delete element from list
        /// </summary>
        /// <returns></returns>
        public int Pop()
        {
            if (head == null)
            {
                return 0;
            }
            int tmp = head.Value;
            head = head.Next;
            --_count;
            return tmp;
        }

        /// <summary>
        /// print all stack
        /// </summary>
        public void Print()
        {
            Element tmp = head;
            do
            {
                Console.Write(tmp.Value + " ");
                tmp = tmp.Next;
            } while (tmp != null);
        }
    }
}
