using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChinczykLib;

namespace ChinczykUnitTest
{
    [TestClass]
    public class PawnTest
    {
        [TestMethod]
        [DataRow(1)]
        public void ConstruktoPawnTest(int i)
        {
            Point a = new Point(1, 1);
            Point[] path = new Point[2];
            Point start = new Point(1, 2);

            Pawn pawn = new Pawn(1, a, path, start);
            Assert.AreEqual(i, pawn.NumberPaw);
        }
    }
}
