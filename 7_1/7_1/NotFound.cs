using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListNamespace
{
    /// <summary>
    /// exception if we do not found element in some base
    /// </summary>
    [Serializable]
    public class NotFoundElement : Exception
    {
        public NotFoundElement() { }
        public NotFoundElement(string message) : base(message) { }
        public NotFoundElement(string message, Exception inner) : base(message, inner) { }
        protected NotFoundElement(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context)
        { }
    }
}
