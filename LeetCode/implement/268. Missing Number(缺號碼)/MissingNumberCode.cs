using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MissingNumberCode : IMissingNumber
    {
        //268. Missing Number(缺號碼)
        public int MissingNumber(int[] nums)
        {
            int missNumber = 0;
            for (int i = 0; i < nums.Length + 1; i++)
            {
                if (nums.Contains(i))
                {
                    continue;
                }
                else
                {
                    missNumber = i;
                    break;
                }
            }
            return missNumber;
        }
    }
}
