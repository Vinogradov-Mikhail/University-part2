using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List node = new List();
            for(int i = 0; i < 6; ++i)
            {
                node.Push(i);
            }
            node.Print();
            node.Pop();
            node.Print();
        }
    }
}
