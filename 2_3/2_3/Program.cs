using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hash tmp = new Hash();
            tmp.Add("trep");
            tmp.Add("pert");
            tmp.Add("trop");
            tmp.Add("treerered");
            tmp.Add("trep");
            tmp.Add("123");
            Console.WriteLine(tmp.Search("pert"));
            tmp.Print();
            Console.WriteLine(tmp.Delete("123"));
            tmp.Print();
        }
    }
}
