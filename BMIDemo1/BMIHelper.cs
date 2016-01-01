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
            // 包成一個工廠
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
