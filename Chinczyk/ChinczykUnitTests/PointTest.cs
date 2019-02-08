using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChinczykLib;

namespace ChinczykUnitTest
{
    [TestClass]
    public class PointTest
    {
        [TestMethod]
        [DataRow(10)]
        public void ConstruktorPointTest(int i)
        {
            Point a = new Point(10, 10);
            Assert.AreEqual(i, a.X);
            Assert.AreEqual(i, a.Y);
        }
    }
}
