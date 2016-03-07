using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HashTableNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            IHash tmp;
            WriteLine(" Choose 1 or 2 variant of hash-function");
            int number = int.Parse(ReadLine());
            if (number == 1)
            {
                tmp = new HashOne();
            }
            else tmp = new HashTwo();
            tmp.Add("trep");
            tmp.Add("pert");
            tmp.Add("trop");
            tmp.Add("treerered");
            tmp.Add("trep");
            tmp.Add("123");
            tmp.Search("pert");
            tmp.Print();
            tmp.Delete("123");
            tmp.Print();
        }
    }
}
