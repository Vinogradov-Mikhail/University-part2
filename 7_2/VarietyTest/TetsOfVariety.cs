using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _7_2.test
{
    [TestClass]
    public class TetsOfVariety
    {
        private Variety<int> temp;
        private Variety<int> tempTwo;

        [TestInitialize]
        public void Inizialize()
        {
            temp = new Variety<int>();
            tempTwo = new Variety<int>();
        }

        [TestMethod]
        public void AddAndFoundTest()
        {
            temp.Add(1);
            Assert.IsTrue(temp.Include(1));
            temp.Add(3);
            temp.Add(1);
            temp.Add(6);
            Assert.IsTrue(temp.Include(3));
            temp.Add(1);
            Assert.IsTrue(temp.Include(6));
        }

        [TestMethod]
        public void AssocTest()
        {
            temp.Add(1);
            temp.Add(3);
            temp.Add(6);
            tempTwo.Add(1);
            tempTwo.Add(3);
            tempTwo.Add(9);
            tempTwo.Add(10);
            temp = temp.Association(temp, tempTwo);
            Assert.IsTrue(temp.Include(1));
            Assert.IsTrue(temp.Include(3));
            Assert.IsTrue(temp.Include(6));
            Assert.IsTrue(temp.Include(9));
            Assert.IsTrue(temp.Include(10));           
        }

        [TestMethod]
        public void InterTest()
        {
            temp.Add(2);
            temp.Add(3);
            temp.Add(6);
            tempTwo.Add(1);
            tempTwo.Add(3);
            tempTwo.Add(2);
            tempTwo.Add(10);
            temp = temp.Intersection(temp, tempTwo);
            Assert.IsTrue(temp.Include(2));
            Assert.IsTrue(temp.Include(3));
            Assert.IsFalse(temp.Include(6));
            Assert.IsFalse(temp.Include(10));
        }
    }
}
