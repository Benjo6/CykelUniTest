using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cykel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cykel.Tests
{
    [TestClass()]
    public class CykelTests
    {
        private Cykel c = new Cykel("Blå", 10, 10, 1);
        [TestMethod()]
        public void CykelTestConstructor()
        {
            Cykel st = new Cykel("Rød", pris: 11, gear: 11, id: 2);
            Assert.AreEqual("Blå", c.Farve);
            Assert.AreEqual(10, c.Pris);
            Assert.AreEqual(10, c.Gear);
            Assert.AreEqual(1, c.Id);
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestPrisLav()
        {
            c.Pris = 0;
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGearLav()
        {
            c.Gear = 2;
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGearHøj()
        {
            c.Gear = 33;
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestFarveNull()
        {
            c.Farve = null;
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void TestFarveKort()
        {
            c.Farve = "";
        }
    }
}