using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIDemo
{
    public abstract class Calculator
    {
        protected double _max;
        protected double _min;
        private double _bmi = 0;
        // 4.利用屬性來賦值
        public double BMI 
        { 
            get
            {
                GetBMIValue();
                return _bmi;
            }
        }
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
        public double Weight { get; set; }
        public double Height { get; set; }

        // 2. 重構 --> 抽出共用程式碼 Max. Min.
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

        // 3. 重構 --> 分離計算職責
        private void GetBMIValue()
        {
            _bmi = this.Weight / Math.Pow(this.Height, 2);
        }
    }
}
