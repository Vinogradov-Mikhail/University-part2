using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorNamespace;

namespace CalculatorNamespace.Tests
{
    [TestClass]
    public class CalcTset
    {
        private Calculator calc;
        private IStack tmp;

        [TestInitialize]
        public void Initialize()
        {
            tmp = new Stack();
            //tmp = new List();
            calc = new Calculator(tmp);
        }

        [TestMethod]
        public void AddElementTest()
        {
            calc.AddElement(5);
            Assert.AreEqual(5, calc.Result());
        }

        [TestMethod]
        public void AdditionTest()
        {
            calc.AddElement(-1);
            calc.AddElement(5);
            calc.Addition();
            Assert.AreEqual(4, calc.Result());
        }

        [TestMethod]
        public void DivideTest()
        {
            calc.AddElement(1);
            calc.AddElement(5);
            calc.Divide();
            Assert.AreEqual(5, calc.Result());
        }

        [TestMethod]
        public void MultyTest()
        {
            calc.AddElement(7);
            calc.AddElement(4);
            calc.Multy();
            Assert.AreEqual(28, calc.Result());
        }

        [TestMethod]
        public void SubstractionTest()
        {
            calc.AddElement(7);
            calc.AddElement(4);
            calc.Subtraction();
            Assert.AreEqual(-3, calc.Result());
        }

        [TestMethod]
        public void UnrealTest()
        {
            calc.AddElement(7);
            calc.AddElement(4);
            calc.Multy();
            Assert.AreEqual(28, calc.Result());
            calc.AddElement(4);
            calc.Subtraction();
            Assert.AreEqual(4, calc.Result());

        }
    }
}
