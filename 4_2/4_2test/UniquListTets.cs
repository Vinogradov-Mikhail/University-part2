using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UniqueListNamespace;

namespace UniqueListNamespace.Test
{
    [TestClass]
    public class UniqueListTest
    {
        private UniqueList list;

        [TestInitialize]
        public void Inizialize()
        {
            list = new UniqueList();
        }

        [TestMethod]
        public void AddAndDeleteTest()
        {
            list.Add(1);
            list.Add(2);
            Assert.AreEqual(1, list.Pop(1));
            list.Delete(2);
            list.Add(12);
            Assert.AreEqual(0, list.Pop(2));
        }

        [TestMethod]
        [ExpectedException(typeof(ULAddAvailableElement))]
        public void AddExceptionTest()
        {
            list.Add(1);
            list.Add(2);
            list.Delete(2);
            list.Add(12);
            list.Add(12);
        }

        [TestMethod]
        [ExpectedException(typeof(ULDeleteNotAvailableElement))]
        public void DeleteExceptionTest()
        {
            list.Add(1);
            list.Add(2);
            list.Delete(2);
            list.Add(12);
            list.Add(112);
            list.Delete(11);
        }
    }
}
