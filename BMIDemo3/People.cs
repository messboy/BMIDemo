using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BMIDemo
{
    public enum Sex
    {
        Man,
        Woman
    }

    public class People
    {
        public Sex Sex { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }

    }
}
