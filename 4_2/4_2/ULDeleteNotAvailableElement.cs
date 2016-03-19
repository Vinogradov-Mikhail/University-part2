using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueListNamespace
{
    /// <summary>
    /// warning if UniqueList doen't have element which user trying delete from list.
    /// </summary>
    [Serializable]
    public class ULDeleteNotAvailableElement : Exception
    {
        public ULDeleteNotAvailableElement() { }
        public ULDeleteNotAvailableElement(string message) : base(message) { }
        public ULDeleteNotAvailableElement(string message, Exception inner) : base(message, inner) { }
        protected ULDeleteNotAvailableElement(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context)
        { }
    }
}
