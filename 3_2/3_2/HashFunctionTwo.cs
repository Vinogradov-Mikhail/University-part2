﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableNamespace
{
    public class HashFunctionTwo : IHashFunction
    {
        /// <summary>
        /// make hash function
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public int HashFunction(string element)
        {
            int symb = 0;
            for (int i = 0; i < element.Length; i++)
            {
                symb += element[i];

            }
            symb *= symb;
            symb >>= 11;
            return symb % 1024; 
        }
    }
}
