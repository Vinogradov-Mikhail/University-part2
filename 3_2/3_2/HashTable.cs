using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableNamespace
{
    public class Hash 
    {
        private static int N = 1000;
        private List[] hash = new List[N];
        private IHashFunction hashF;
        /// <summary>
        /// constructor for hashtable
        /// </summary>
        public Hash(IHashFunction getHashFunction)
        {
            hashF = getHashFunction;
            for (int i = 0; i < N; ++i)
            {
                hash[i] = new List();
            }
        }

        /// <summary>
        /// add element in hashtable
        /// </summary>
        /// <param name="element"></param>
        public void Add(string element)
        {
            hash[hashF.HashFunction(element)].Push(element);
        }

        /// <summary>
        /// delete element from hashtable
        /// </summary>
        /// <param name="element"></param>
        public bool Delete(string element)
        {
            return (hash[hashF.HashFunction(element)].Pop(element) != "");
        }

        /// <summary>
        /// search element in hashtable
        /// </summary>
        /// <param name="element"></param>
        public bool Search(string element)
        {
            return (hash[hashF.HashFunction(element)].Find(element));
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
