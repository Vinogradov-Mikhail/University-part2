using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ListNamespace.Test
{
    /// <summary>
    /// unittest for stack with generic
    /// </summary>
    [TestClass]
    public class StackTest
    {
        private Stack<string> list;

        [TestInitialize]
        public void Inizialize()
        {
            list = new Stack<string>();
        }

        [TestMethod]
        public void PushTest()
        {
            list.Push("olol");
            list.Push("tralivali");
            Assert.AreEqual("tralivali", list.Pop());
        }
    }
}
