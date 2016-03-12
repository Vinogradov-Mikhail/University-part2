using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableNamespace
{
    /// <summary>
    /// interface for hashfunction
    /// </summary>
    public interface IHashFunction
    {
        /// <summary>
        /// make hash function
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        int HashFunction(string element);
    }
}
