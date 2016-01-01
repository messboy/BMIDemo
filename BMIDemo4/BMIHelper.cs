using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIDemo
{
    public class BMIHelper
    {

        internal static Calculator GetCalculator(People member)
        {
           // 使用反射屬性來取得條件,消除if else
            BoundryHelper helper = new BoundryHelper(member.Sex);
            var bmi = GetBMIValue(member.Weight, member.Height);

            Calculator result = new Calculator(bmi, helper.Max, helper.Min);
            return result;
        }



        private static double GetBMIValue(double weight, double height)
        {
            return weight / Math.Pow(height, 2);
        }

    }

    public class BoundryHelper
    {
        public double Max { get; set; }
        public double Min { get; set; }

        public BoundryHelper(Sex sex)
        {
            // 取得欄位
            var field = typeof(Sex).GetField(sex.ToString());

            // 取得該欄位指定屬性
            var attribute = Attribute.GetCustomAttribute(field, typeof(SexBoundaryAttribute));

            Min = ((SexBoundaryAttribute)attribute).Min;
            Max = ((SexBoundaryAttribute)attribute).Max;
        }

    }
}
