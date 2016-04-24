using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListNamespace
{
    /// <summary>
    /// generic class for list
    /// </summary>
    public class List<T> : IEnumerable
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
            public Element(T value, Element next = null)
            {
                this.Value = value;
                this.Next = next;
            }
        }
        private Element head;// new Element(null, null);
        private int _count;

        /// <summary>
        /// stack constructor 
        /// </summary>
        public List(T value)
        {
            head = new Element(value, null);
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
            head = new Element(value, head);
            ++_count;
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
        /// add element in postion
        /// </summary>
        /// <param name="index"></param>
        /// <param name="value"></param>
        public void InIndex(int index, T value)
        {
            ++_count;
            if ((head == null) || (index == 0))
            {
                head = new Element(value, head);
                return;
            }
            Element newElem = new Element(value, null);
            Element temp = head;
            for(int i = 0; temp.Next != null & i < index - 1; ++i)
            {
                temp = temp.Next;
            }
            newElem.Next = temp.Next;
            temp.Next = newElem; 
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
        /// remove element from position
        /// </summary>
        /// <param name="index"></param>
        public void RemomeAt(int index)
        {
            if (head == null)
                return;
            if (index == 0)
            {
                T tmp = head.Value;
                head = head.Next;
                --_count;
            }
            Element temp = head;
            Element secondTemp = head;
            int i = 1;
            while (temp.Next != null)
            {
                temp = temp.Next;
                if (i == index)
                {
                    secondTemp.Next = temp.Next;
                    --_count;
                }
                secondTemp = temp;
                ++i;
            }
            return;
        }

        /// <summary>
        /// print all stack
        /// </summary>
        public void Print()
        {
            Element tmp = head;
            while (tmp.Next != null)
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
        public bool Find(int element)
        {
            Element tmp = head;
            for (int i = 0; i <= _count; ++i)
            {
                if (tmp.Value.Equals(element))
                {
                    return true;
                }
                tmp = tmp.Next;
            }
            return false;
        }

        /// <summary>
        /// implementation for the GetEnumerator method
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
        
        /// <summary>
        /// enumerator for list
        /// </summary>
        /// <returns></returns>
        public ListEnum GetEnumerator()
        {
            return new ListEnum(this);
        }

        /// <summary>
        /// class for list enumerator
        /// </summary>
        public class ListEnum : IEnumerator
        {
            private List<T> head;
            private Element elem = null;
            private int position = -1;

            /// <summary>
            /// constuctor
            /// </summary>
            /// <param name="head"></param>
            public ListEnum(List<T> head)
            {
                this.head = head;
            }

            /// <summary>
            /// move to the next element of list
            /// </summary>
            /// <returns></returns>
            public bool MoveNext()
            {
                position++;
                elem = elem == null ? head.head : elem.Next;
                return (position < head.Length());
            }

            /// <summary>
            /// reset enumerator
            /// </summary>
            public void Reset()
            {
                elem = null;
                position = -1;
            }

            /// <summary>
            ///  return current value of list in enumerator
            /// </summary>
            object IEnumerator.Current
            {
                get
                {
                    return Current;
                }
            }

            /// <summary>
            /// return current value of list
            /// </summary>
            public T Current
            {
                get
                {
                    try
                    {
                        return elem.Value;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        throw new InvalidOperationException();
                    }
                }
            }
        }

    }
}
