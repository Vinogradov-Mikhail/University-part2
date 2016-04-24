using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListNamespace
{
    /// <summary>
    /// exception if something do not have elements
    /// </summary>
    [Serializable]
    public class DoNotHaveElements : Exception
    {
        public DoNotHaveElements() { }
        public DoNotHaveElements(string message) : base(message) { }
        public DoNotHaveElements(string message, Exception inner) : base(message, inner) { }
        protected DoNotHaveElements(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context)
        { }
    }
}
