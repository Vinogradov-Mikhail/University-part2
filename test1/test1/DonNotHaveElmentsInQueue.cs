using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueNamespace
{
    [Serializable]
    public class DonNotHaveElmentsInQueue : Exception
    {
        public DonNotHaveElmentsInQueue() { }
        public DonNotHaveElmentsInQueue(string message) : base(message) { }
        public DonNotHaveElmentsInQueue(string message, Exception inner) : base(message, inner) { }
        protected DonNotHaveElmentsInQueue(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context)
        { }
    }
}
