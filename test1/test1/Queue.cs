using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueNamespace
{
    public class Queue
    {
        /// <summary>
        /// class for element of queue
        /// </summary>
        public class QueueElement
        {
            public int Value { get; set; }
            /// <summary>
            /// priority foe each element: max prior = 0;
            /// </summary>
            public int Prior { get; set; }
            public QueueElement Next { get; set; }

            /// <summary>
            /// constructor for list element
            /// </summary>
            /// <param name="_value"></param>
            /// <param name="next"></param>
            public QueueElement(int value = 0, int prior = 0, QueueElement next = null)
            {
                this.Value = value;
                this.Prior = prior;
                this.Next = next;
            }
        }

        private QueueElement head;

        /// <summary>
        /// constructor
        /// </summary>
        public Queue()
        {
            head = null;
        }

        /// <summary>
        /// add elememnt in queue include checking priority
        /// </summary>
        /// <param name="num"></param>
        /// <param name="prior"></param>
        public void EnQueue(int num, int prior)
        {
            if(head == null || head.Prior > prior)
            {
                head = new QueueElement(num, prior, head);
                return;
            }
            QueueElement newElem = new QueueElement(num, prior, null);
            QueueElement temp = head;
            while (temp.Next != null && newElem.Prior >= temp.Next.Prior) 
            {
                temp = temp.Next;
            }
            newElem.Next = temp.Next;
            temp.Next = newElem;
        }

        /// <summary>
        /// return element from chose position
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int GetElement(int index)
        {
            QueueElement temp = head;
            for (int i = 0; temp.Next != null & i < index - 1; ++i)
            {
                temp = temp.Next;
            }
            return temp.Value;
        }

        /// <summary>
        /// delete elment with max priority
        /// </summary>
        /// <returns></returns>
        public int DeQueue()
        {
            if (head == null)
            {
                throw new DonNotHaveElmentsInQueue("Queue is Empty!!!!!!");
            }
            int tmp = head.Value;
            head = head.Next;
            return tmp;
        }

        /// <summary>
        /// print all list
        /// </summary>
        public void Print()
        {
            Console.WriteLine();
            Console.Write("|cashbox| ");
            QueueElement tmp = head;
            do
            {
                Console.Write(tmp.Value + " ");
                tmp = tmp.Next;
            } while (tmp != null);
        }

        /// <summary>
        /// find element in queue
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public bool Find(int element)
        {
            QueueElement tmp = head;
            while (tmp != null)
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
