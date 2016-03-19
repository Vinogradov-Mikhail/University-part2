using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueListNamespace
{
    /// <summary>
    /// class for list which have unique elements
    /// </summary>
    public class UniqueList : List
    {
        /// <summary>
        /// add element in UniqueList. Throw exception if list have this value
        /// </summary>
        /// <param name="number"></param>
        override public void Add(int number)
        {
            if (Find(number))
            {
                throw new ULAddAvailableElement("Try add another element, because this element available in list");
            }
            else Add(number);
        }

        /// <summary>
        /// delete element from UniqueList. Throw exception if list doesn't have this value
        /// </summary>
        /// <param name="number"></param>
        override public int Delete(int number)
        {
            if (Find(number))
            {    
                return Delete(number);
            }
            else throw new ULDeleteNotAvailableElement("Try delete another element, because this element not available in list");
        }
    }
}
