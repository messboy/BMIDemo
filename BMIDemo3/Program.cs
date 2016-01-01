using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMIDemo;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 提供人員資訊 --> 1. 調整型別enum
            var member = new People() { Sex = Sex.Woman, Height = 1.7, Weight = 95 };

            // 傳給BMIHelper 產生計算物件
            Calculator calculator = BMIHelper.GetCalculator(member);

            // 回傳結果
            Console.WriteLine(calculator.Result);

        }
    }
}
