using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueListNamespace
{
    /// <summary>
    /// class for list
    /// </summary>
    public class List
    {
        /// <summary>
        /// class for element of list
        /// </summary>
        class Element
        {
            public int Value { get; set; }
            public Element Next { get; set; }

            /// <summary>
            /// constructor for list element
            /// </summary>
            /// <param name="_value"></param>
            /// <param name="next"></param>
            public Element(int value = 0, Element next = null)
            {
                this.Value = value;
                this.Next = next;
            }
        }
        private Element head = null;// new Element();

        /// <summary>
        /// list constructor 
        /// </summary>
        public List()
        {
        }

        /// <summary>
        /// find element in list
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public bool Find(int element)
        {
            Element tmp = head;
            if (tmp == null)
                return false;
            do
            {
                if (tmp.Value == element)
                {
                    return true;
                }
                tmp = tmp.Next;
            } while (tmp != null);
            return false;
        }

        /// <summary>
        /// add element in list
        /// </summary>
        /// <param name="value"></param> 
        virtual public void Add(int value)
        {
            head = new Element(value, head);
        }

        /// <summary>
        /// get element from position
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int GetElement(int index)
        {
            Element temp = head;
            for (int i = 0; temp.Next != null & i < index - 1; ++i)
            {
                temp = temp.Next;
            }
            return temp.Value;
        }

        /// <summary>
        /// delete element from list
        /// </summary>
        /// <returns></returns>
        virtual public int Delete(int elem)
        {
            if (head == null)
                 return 0;
            if (head.Value == elem)
            {
                int tmp = head.Value;
                head = head.Next;
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
                    return temp.Value;
                }
                secondTemp = temp;
            }
            return 0;
        }

        /// <summary>
        /// print all list
        /// </summary>
        public void Print()
        {
            Console.WriteLine();
            Element tmp = head;
            do
            {
                Console.Write(tmp.Value + " ");
                tmp = tmp.Next;
            } while (tmp != null);
        }
    }
}
