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
            tmp.InIndex(1, 2);
            tmp.InIndex(0, 1);
            tmp.Print();
            tmp.Pop(2);
            tmp.Print();
            tmp.InIndex(2, 3);
            tmp.Print();
            tmp.RemomeAt(1);
            tmp.Print();
        }
    }
}
