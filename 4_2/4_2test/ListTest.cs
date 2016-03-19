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
            tmp.Add(1);
            Assert.AreEqual(1, tmp.Delete(1));
        }

        [TestMethod]
        public void FindTest()
        {
            tmp.Add(1);
            tmp.Add(232);
            tmp.Add(3);
            tmp.Add(4);
            tmp.Add(554);
            tmp.Add(12);
            Assert.AreEqual(true, tmp.Find(554));
            tmp.Add(23);
        }

        [TestMethod]
        public void GetElementTest()
        {
            tmp.Add(1);
            tmp.Add(232);
            tmp.Add(12);
            tmp.Add(3);
            tmp.Add(4);
            tmp.Add(554);
            Assert.AreEqual(12, tmp.GetElement(0));
        }
    }
}
