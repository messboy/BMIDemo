﻿using System;
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
            Dictionary<string, Func<Calculator>> mappingTable = new Dictionary<string, Func<Calculator>>();
            mappingTable.Add("Man", () => { return new ManCaculator(member); });
            mappingTable.Add("Woman", () => { return new ManCaculator(member); });

            return mappingTable[member.Sex].Invoke();
        }
    }
}
