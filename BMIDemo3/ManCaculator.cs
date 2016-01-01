using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BMIDemo
{
    public class ManCaculator : Calculator
    {
        public ManCaculator(People member)
        {
            this.Weight = member.Weight;
            this.Height = member.Height;
            
            // 設定條件
            this._max = 25;
            this._min = 20;
        }

        
    }
}
