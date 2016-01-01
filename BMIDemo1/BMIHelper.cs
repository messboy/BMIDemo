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
             // 依照性別給出特定BMI計算器
            Calculator cal = BMIFactory(member);
            return cal;
        }

        private static Calculator BMIFactory(People member)
        {
            if (member.Sex == "Man")
            {
                return new ManCaculator(member);
            }
            else 
            {
                return new WomanCaculator(member);
            }
        }


    }
}
