using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableNamespace
{
    public class List
    {
        /// <summary>
        /// class for element of stack
        /// </summary>
        class Element
        {
            public string Value { get; set; }
            public Element Next { get; set; }

            /// <summary>
            /// constructor for stack element
            /// </summary>
            /// <param name="_value"></param>
            /// <param name="next"></param>
            public Element(string _value = "", Element next = null)
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
        public List()
        {
            _count = -1;
        }

        /// <summary>
        /// add element in stack
        /// </summary>
        /// <param name="value"></param> 
        public void Push(string value)
        {
            head = new Element(value, head);
            ++_count;
        }

        /// <summary>
        /// delete element from list
        /// </summary>
        /// <returns></returns>
        public string Pop(string elem)
        {
            if (head == null)
                return "";
            if (head.Value == elem)
            {
                string tmp = head.Value;
                head = head.Next;
                --_count;
                return tmp;
            }
            Element temp = head;
            Element secondTemp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
                if (temp.Value == elem)
                {
                    secondTemp.Next = temp.Next;
                    --_count;
                    return temp.Value;
                }
                secondTemp = temp;
            }
            return "";
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

        public bool HaveElements()
        {
            return _count != -1;
        }

        /// <summary>
        /// find element in list
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public bool Find(string element)
        {
            Element tmp = head;
            for (int i = 0; i <= _count; ++i)
            {
                if (tmp.Value == element)
                {
                    return true;
                }
                tmp = tmp.Next;
            }
            return false;
        }
    }
}
