using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Variety<int> temp = new Variety<int>();
            Variety<int> tempTwo = new Variety<int>();
            temp.Add(1);
            //Console.Write(temp.list.Length());
            temp = temp.Association(temp, tempTwo);
            temp.Show();
        }
    }
}
