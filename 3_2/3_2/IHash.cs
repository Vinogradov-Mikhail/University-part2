using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableNamespace
{
    interface IHash
    {
        /// <summary>
        /// make hash function
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        int hashFunction(string element);

        /// <summary>
        /// add element in hashtable
        /// </summary>
        /// <param name="element"></param>
        void Add(string element);

        /// <summary>
        /// delete element from hashtable
        /// </summary>
        /// <param name="element"></param>
        void Delete(string element);

        /// <summary>
        /// search element in hashtable
        /// </summary>
        /// <param name="element"></param>
        void Search(string element);

        /// <summary>
        /// priant all elements
        /// </summary>
        void Print();
    }
}
