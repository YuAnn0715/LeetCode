using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class FindErrorNumsCode : IFindErrorNums
    {
        //645. Set Mismatch(設定不匹配)
        public int[] FindErrorNums(int[] nums)
        {
            int n = nums.Length;
            int[] result = new int[2];
            bool[] seen = new bool[n + 1];
            foreach (int num in nums)
            {
                if (seen[num])
                {
                    result[0] = num;
                }
                seen[num] = true;
            }
            for (int i = 1; i <= n; i++)
            {
                if (!seen[i])
                {
                    result[1] = i;
                    break;
                }
            }
            return result;
        }
    }
}
