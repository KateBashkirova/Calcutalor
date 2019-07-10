﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedCalculator.TwoArgumentsFunctions
{
    public class DivCalculator:ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return (int)(firstValue / secondValue);
        }
    }
}