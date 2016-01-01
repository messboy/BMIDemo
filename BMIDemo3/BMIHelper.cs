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
            // 使用Dictionary 消除if else
            Dictionary<Sex, Func<Calculator>> mappingTable = new Dictionary<Sex, Func<Calculator>>();
            mappingTable.Add(Sex.Man, () => { return new ManCaculator(member); });
            mappingTable.Add(Sex.Woman, () => { return new ManCaculator(member); });

            return mappingTable[member.Sex].Invoke();
        }
    }
}
