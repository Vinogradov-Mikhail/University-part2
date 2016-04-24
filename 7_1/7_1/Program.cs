using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(0);
            list.Push(1);
            list.Push(2);
            list.Push(3);
            list.Push(4);
            list.Push(5);
            list.Push(6);
            list.Push(7);
            foreach(int element in list)
            {
                //Console.Write(element);
                if (element == 1)
                {
                    Console.Write("+");
                }
            }
            list.Print();

        }
    }
}
