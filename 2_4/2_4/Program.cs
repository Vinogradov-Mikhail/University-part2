using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class List : IStack
    {
        class ArrayList
        {
            private static int length = 50;
            private int[] arrayList = new int[length];

            /// <summary>
            /// count elemnts in array list
            /// </summary>
            private int count;

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
                if(ItIsNotFree())
                {
                    int tmp = arrayList[count];
                    if (count != length - 1)
                    {
                        arrayList[count] = arrayList[count + 1];
                    }
                    else arrayList[count] = 0;
                    --count;
                    return tmp;
                }
                return 0;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public int GetLength()
            {
                return count;
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
            if (list.ItIsNotFree())
            {
                list.ShowElement();
            }
            else Console.WriteLine(" List is empty");
        }

    }
    class Stack : IStack
    {
        /// <summary>
        /// class for element of stack
        /// </summary>
        class Element
        {
            //public int Value { get; set; }
            //public Element Next { get; set; }
            private int _value;
            private Element next;

            public Element(int value = 0, Element next = null)
            {
                this.value = value;
                this.next = next;
            }
            /// <summary>
            /// function for get or write value from element of stack
            /// </summary>
            public int Value
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
        public void Push(int value)
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

    class Calculator
    {
        private IStack stack;

        public Calculator(IStack tmp)
        {
            stack = tmp;
        }

        public void AddElement(int value)
        {
            stack.Push(value);
        }

        public void Addition()
        {
            int sum = stack.Pop() + stack.Pop();
            //stack.Push(sum);
        }

        public void Result()
        {
            stack.Print();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            IStack tmp;
            tmp = new Stack();
            Calculator calc = new Calculator(tmp);
            calc.AddElement(8);
            calc.AddElement(9);
            //calc.AddElement(10);
            calc.Addition();
            calc.Result();

        }
    }
}
