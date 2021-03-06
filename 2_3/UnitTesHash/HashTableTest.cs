﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HashTable;

namespace HashTable.Test
{
    [TestClass]
    public class HashTableTest
    {
        private Hash tmp;

        [TestInitialize]
        public void Inizialaze()
        {
            tmp = new Hash();
        }

        [TestMethod]
        public void HashTableTests()
        {
            tmp.Add("trep");
            tmp.Add("ololol");
            tmp.Add("pert");
            Assert.AreEqual(true, tmp.Search("trep"));
            tmp.Add("pet");
            tmp.Delete("pet");
            Assert.AreEqual(false, tmp.Delete("pet"));
            tmp.Add("11rt");
        }
    }
}
