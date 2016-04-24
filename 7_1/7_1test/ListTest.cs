using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ListNamespace.Test
{
    /// <summary>
    /// unit test for list with enumerator
    /// </summary>
    [TestClass]
    public class ListTest
    {
        private List<int> list;

        [TestInitialize]
        public void Inizialize()
        {
            list = new List<int>(0);
        }
        
        [TestMethod]
        public void PushAndPopTest()
        {
            list.Push(1);
            Assert.AreEqual(1, list.Pop(1));
            list.Push(3);
            list.Push(2);
            list.Push(1);
            list.Push(4);
            Assert.AreEqual(2, list.Pop(2));
        }

        [TestMethod]
        public void ForeachTest()
        {
            list.Push(3);
            list.Push(2);
            list.Push(1);
            list.Push(4);
            int i = 0;
            foreach(int element in list)
            {
                if (element != 0)
                    ++i;
            }
            Assert.AreEqual(4, i);
        }
    }
}
