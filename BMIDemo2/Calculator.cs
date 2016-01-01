using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIDemo
{
    public abstract class Calculator
    {
        public double BMI { get; set; }
        public string Message { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        internal abstract string GetResult();

    }
}
