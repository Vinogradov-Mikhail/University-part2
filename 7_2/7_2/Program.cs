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
            Variety<int> get = new Variety<int>(0);
            Variety<int> get2 = new Variety<int>(0);
            get.Add(1);
            get.Add(2);
            get.Add(1);
            get.Add(1);
            get2.Add(1);
            get2.Add(2);
            get2.Add(0);
            get.Show();
            Console.WriteLine();
            get2.Show();
            Console.WriteLine();
            get = get.Intersection(get, get2);
            get.Show();
        }
    }
}
