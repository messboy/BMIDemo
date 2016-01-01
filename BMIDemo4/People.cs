using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BMIDemo
{
    public class SexBoundaryAttribute : Attribute
    {
        public double Max { get; set; }
        public double Min { get; set; }

        public SexBoundaryAttribute(int min, int max)
        {
            Max = max;
            Min = min;
        }
    }

    public enum Sex
    {
        [SexBoundary(20,25)]
        Man,
        [SexBoundary(18, 22)]
        Woman
    }

    public class People
    {
        public Sex Sex { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }

    }
}
