using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class CountBitsCode : ICountBits
    {
        //338. Counting Bits(計數位)
        public int[] CountBits(int n)
        {
            List<int> one = new List<int>();
            for (int i = 0; i < n + 1; i++)
            {
                string binary = Convert.ToString(i, 2);
                int countOne = 0;
                for (int j = 0; j < binary.Length; j++)
                {
                    if (binary[j] == '1')
                    {
                        countOne++;
                    }
                }
                one.Add(countOne);
            }
            return one.ToArray();
        }
    }
}
