using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UniqueListNamespace;

namespace UniqueListNamespace.Test
{
    [TestClass]
    public class ListTest
    {
        private List tmp;

        [TestInitialize]
        public void Inizialize()
        {
            tmp = new List();
        }

        [TestMethod]
        public void PushPopTest()
        {
            tmp.Push(1);
            Assert.AreEqual(1, tmp.Pop(1));
            tmp.Pop(1);
            Assert.AreEqual(0, tmp.Pop(1));
        }

        [TestMethod]
        public void FindTest()
        {
            tmp.Push(1);
            tmp.Push(232);
            tmp.Push(1);
            tmp.Push(3);
            tmp.Push(4);
            tmp.Push(554);
            tmp.Push(12);
            tmp.Push(1);
            Assert.AreEqual(true, tmp.Find(554));
            tmp.Push(23);
        }

        [TestMethod]
        public void InIndexAndRemoveAtTEst()
        {
            tmp.InIndex(1, 2);
            tmp.InIndex(0, 1);
            Assert.AreEqual(2, tmp.Pop(2));
            tmp.InIndex(2, 3);
            tmp.RemoveAt(2);
            Assert.AreEqual(3, tmp.Pop(3));
        }

        [TestMethod]
        public void GetElementTest()
        {
            tmp.Push(1);
            tmp.Push(232);
            tmp.Push(12);
            tmp.Push(3);
            tmp.Push(4);
            tmp.Push(554);
            tmp.Push(12);
            Assert.AreEqual(12, tmp.GetElement(0));
        }
    }
}
