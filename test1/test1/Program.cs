using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue tmp = new Queue();
            tmp.EnQueue(7, 2);
            tmp.EnQueue(6, 2);
            tmp.EnQueue(3, 2);
            tmp.EnQueue(2, 2);
            tmp.EnQueue(9, 1);
            tmp.EnQueue(8, 1);
            tmp.EnQueue(10, 0);
            tmp.EnQueue(11,5);
            Console.Write(tmp.Find(11));
            //tmp.DeQueue();
            tmp.Print();
        }
    }
}
