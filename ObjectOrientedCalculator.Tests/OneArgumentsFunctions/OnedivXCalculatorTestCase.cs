﻿using System;
using ObjectOrientedCalculator.OneArgumentsFunctions;
using NUnit.Framework;

namespace ObjectOrientedCalculator.Tests.OneArgumentsFunctions
{
    [TestFixture]
    public class OnedivXCalculatorTestCase
    {
        [Test]
        public void OnedivXCaltulatorExceptionTest()
        {
            Assert.Throws<Exception>(() => new OnedivXCalculator().Calculate(0));
        }

        [TestCase(2, 0.5)]
        [TestCase(-2, -0.5)]
        [TestCase(-4, -0.25)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new OnedivXCalculator();
            var actual = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}