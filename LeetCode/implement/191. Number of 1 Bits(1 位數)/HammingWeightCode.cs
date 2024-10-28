using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class HammingWeightCode:IHammingWeight
    {
        //191. Number of 1 Bits(1 位數)
        public int HammingWeight(uint n)
        {
            string s = Convert.ToString(n, 2);
            int total = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '1')
                {
                    total++;
                }
            }
            return total;
        }
    }
}
