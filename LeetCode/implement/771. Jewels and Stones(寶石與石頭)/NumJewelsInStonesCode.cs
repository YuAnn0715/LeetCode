using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class NumJewelsInStonesCode: INumJewelsInStones
    {
        // 771. Jewels and Stones(寶石與石頭)
        public int NumJewelsInStones(string jewels, string stones)
        {
            char[] jewelsArray = jewels.ToCharArray();
            int isJewels = 0;
            foreach (var item in stones)
            {
                if (jewelsArray.Contains(item))
                {
                    isJewels++;
                }
            }
            return isJewels;
        }
    }
}
