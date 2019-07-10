﻿
using ObjectOrientedCalculator.TwoArgumentsFunctions;
using NUnit.Framework;

namespace ObjectOrientedCalculator.Tests.TwoArgumentsFunctions
{
    [TestFixture]
    public class DivisionCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            double expected = 0.666;
            double actual = new DivisionCalculator().Calculate(2, 3);
            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}