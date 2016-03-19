using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueListNamespace
{
    /// <summary>
    /// warning if UniqueList have element which user trying add in list.
    /// </summary>
    [Serializable]
    public class ULAddAvailableElement : Exception
    {
        public ULAddAvailableElement() { }
        public ULAddAvailableElement(string message) : base(message) { }
        public ULAddAvailableElement(string message, Exception inner) : base(message, inner) { }
        protected ULAddAvailableElement(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context)
        { }
    }
}
