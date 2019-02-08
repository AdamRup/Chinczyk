using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChinczykLib;

namespace ChinczykUnitTest
{
    [TestClass]
    public class HumanPlayerTest
    {
        [TestMethod]
        [DataRow("Adam", 2)]
        public void ConstruktorHumanPlayerTest(string name, int i)
        {
            Point a = new Point(0, 0);
            Point[] path = new Point[1];
            Point[] tab1 = new Point[4];
            for (int ii = 0; ii < tab1.Length; ii++)
            {
                tab1[i] = new Point(0, 0);

            }
            Point[] tab2 = tab1;

            Point start = new Point(10, 10);
            Dice dice = new Dice();
            Player p1 = new HumanPlayer(name, i, tab1, tab2, start, dice);

            Assert.AreEqual(name, p1.Name);
            Assert.AreEqual(i, p1.Number);
        }
    }
}
