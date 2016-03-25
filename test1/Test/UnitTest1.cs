using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueueNamespace;

namespace QueueNamespace.Test
{
    [TestClass]
    public class QueueTest
    {
        private Queue queue;

        [TestInitialize]
        public void Inizialize()
        {
            queue = new Queue();
        }

        [TestMethod]
        public void EnQueueTest()
        {
            queue.EnQueue(1, 2);
            queue.EnQueue(3, 2);
            queue.EnQueue(77, 5);
            queue.EnQueue(213, 1);
            queue.EnQueue(13, 2);
            queue.EnQueue(12, 2);
            Assert.AreEqual(true, queue.Find(77));
            Assert.AreEqual(3, queue.GetElement(3));
        }

        [TestMethod]
        public void DeQueueTEst()
        {
            queue.EnQueue(213, 1);
            queue.EnQueue(13, 2);
            queue.EnQueue(12, 2);
            Assert.AreEqual(213, queue.DeQueue());
            queue.DeQueue();
            Assert.AreNotEqual(213, queue.DeQueue());
        }

        [TestMethod]
        [ExpectedException(typeof(DonNotHaveElmentsInQueue))]
        public void EmptyExceptionTest()
        {
            queue.EnQueue(1, 2);
            queue.EnQueue(3, 2);
            queue.EnQueue(77, 5);
            queue.DeQueue();
            queue.DeQueue();
            queue.DeQueue();
            queue.DeQueue();
        }
    }
}
