using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _5_123.Test
{
    [TestClass]
    public class SomeFunctionTest
    {
        private SomeFunction func;
        private List list;

        [TestInitialize]
        public void Inizialize()
        {
            func = new SomeFunction();
            list = new List();
        }

        [TestMethod]
        public void TestMap()
        {
            list.Push(1);
            list.Push(2);
            list.Push(3);
            list = func.Map(list, x => x * 2);
            Assert.AreEqual(6, list.Pop(6));
            Assert.AreEqual(4, list.Pop(4));
            Assert.AreEqual(2, list.Pop(2));
        }

        [TestMethod]
        public void TestFilter()
        {
            list.Push(1);
            list.Push(4);
            list.Push(6);
            list = func.Filter(list, x => x > 4);
            Assert.AreEqual(6, list.Pop(6));
            Assert.AreEqual(0, list.Pop(4));
        }

        [TestMethod]
        public void TestFolder()
        {
            list.Push(1);
            list.Push(2);
            list.Push(3);
            Assert.AreEqual(6, func.Fold(list, 1, (acc, elem) => acc * elem));
        }
    }
}
