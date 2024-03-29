﻿using System;
using ObjectOrientedCalculator.Interfaces;

namespace ObjectOrientedCalculator.TwoArgumentsFunctions
{
    /// <summary>
    /// Calculator that selects the maximum of two numbers
    /// </summary>
    public class MaxXYCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// The method that selects the maximum of two numbers
        /// </summary>
        /// <param name="firstValue">argument one</param>
        /// <param name="secondValue">argument two</param>
        /// <returns>result</returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Max(firstValue, secondValue);
        }
    }
}
