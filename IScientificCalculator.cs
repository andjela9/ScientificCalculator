using System;
using System.Collections.Generic;
using System.Text;

namespace domaci
{
    interface IScientificCalculator
    {
        public abstract double Square(double x);

        public abstract double SquareRoot(double x);

        public abstract double AbsoluteValue(double x);

        public abstract double Power(double x, double y);

    }
}
