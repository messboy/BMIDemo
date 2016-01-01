using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BMIDemo
{
    public class WomanCaculator : Calculator
    {
        public WomanCaculator(People member)
        {
            this.Weight = member.Weight;
            this.Height = member.Height;
        }

        internal override string GetResult()
        {
            this.BMI = this.Weight / Math.Pow(this.Height, 2);
            string result = string.Empty;

            if (this.BMI < 18)
            {
                result = "太瘦";
            }
            else if (this.BMI > 22)
            {
                result = "太胖";
            }
            else
            {
                result = "適中";
            }

            return result;
        }
    }
}
