﻿namespace ObjectOrientedCalculator.TwoArgumentsFunctions
{
    public class DivisionCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue / secondValue;
        }
    }
}