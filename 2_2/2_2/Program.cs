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
            List tmp = new List();
            for (int i = 0; i < 10; ++i)
            {
                tmp.Push(i);
            }
            tmp.InIndex(1, 11);
            tmp.RemomeAt(3);
            tmp.Pop(11);
            tmp.Print();
        }
    }
}
