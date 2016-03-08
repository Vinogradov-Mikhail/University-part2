using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{ 
    /// <summary>
    /// class for making hashtable
    /// </summary>
    public class Hash
    {
        private const int N = 1000;
        private List[] hash = new List[N];

        /// <summary>
        /// constructor for hashtable
        /// </summary>
        public Hash()
        {
            for (int i = 0; i < N; ++i)
            {
                hash[i] = new List();
            }
        }

        /// <summary>
        /// make hash function
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        private int HashFunction(string element)
        {
            int symb = 0;
            for (int i = 0; i < element.Length; i++)
            {
                symb += element[i];

            }
            return symb % N;
        }

        /// <summary>
        /// add element in hashtable
        /// </summary>
        /// <param name="element"></param>
        public void Add(string element)
        {
            hash[HashFunction(element)].Push(element);
        }

        /// <summary>
        /// delete element from hashtable
        /// </summary>
        /// <param name="element"></param>
        public bool Delete(string element)
        {
            return (hash[HashFunction(element)].Pop(element) != "");
        }

        /// <summary>
        /// search element in hashtable
        /// </summary>
        /// <param name="element"></param>
        public bool Search(string element)
        {
            return (hash[HashFunction(element)].Find(element));
        }

        /// <summary>
        /// priant all elements
        /// </summary>
        public void Print()
        {
            for (int i = 0; i < N; ++i)
            {
                if (hash[i].HaveElements())
                {
                    hash[i].Print();
                    Console.WriteLine();
                }
            }
        }
    }

}
