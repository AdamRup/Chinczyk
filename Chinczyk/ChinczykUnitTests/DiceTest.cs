using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChinczykLib;

namespace ChinczykUnitTest
{
    [TestClass]
    public class DiceTest
    {
        [TestMethod]
        public void isDiceRollNotNullTest()
        {
            Dice dice = new Dice();
            dice.Roll();
            Assert.IsNotNull(dice.Value);
        }

        [TestMethod]
        public void isDiceRollContainsValuesFromOneToSixTest()
        {
            Dice dice = new Dice();
            dice.Roll();
            bool isDiceValueLowerThanSeven;
            if (dice.Value < 7 && dice.Value > 0)
            {
                isDiceValueLowerThanSeven = true;
            }
            else
            {
                isDiceValueLowerThanSeven = false;
            }

            Assert.IsTrue(isDiceValueLowerThanSeven);
        }

    }
}