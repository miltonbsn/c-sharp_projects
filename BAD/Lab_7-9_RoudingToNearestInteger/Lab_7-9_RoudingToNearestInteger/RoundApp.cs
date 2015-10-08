using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_7_9_RoudingToNearestInteger
{
    class RoundApp
    {
        public double RoundToTheNearestInteger(double value)
        {
            double y = Math.Floor(value + 0.5);
            // Another ways to do it:
            // Math.round(value)
            // Convert.ToInt32(value)
            return y;
        }
    }

}
