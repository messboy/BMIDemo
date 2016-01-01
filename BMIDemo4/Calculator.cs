using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIDemo
{
    public class Calculator
    {
        public Calculator(double bmi, double max, double min) 
        {
            BMI = bmi;
            _max = max;
            _min = min;
        }

        protected double _max;
        protected double _min;
        public double BMI { get; set; }
        // 4.利用屬性來賦值
        private string _result = string.Empty;
        public string Result
        { 
            get 
            {
                GetResult();
                return _result;
            } 
        }

        public string Message { get; set; }

        private void GetResult()
        {
            string result = string.Empty;

            if (this.BMI < _min)
            {
                result = "太瘦";
            }
            else if (this.BMI > _max)
            {
                result = "太胖";
            }
            else
            {
                result = "適中";
            }

            _result = result;
        }


        
    }
}
