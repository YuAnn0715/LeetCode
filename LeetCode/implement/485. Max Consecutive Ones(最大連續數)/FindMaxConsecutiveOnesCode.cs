using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class FindMaxConsecutiveOnesCode : IFindMaxConsecutiveOnes
    {
        //485. Max Consecutive Ones(最大連續數)
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            List<int> isOne = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int count = 0;
                if (nums[i] == 1)
                {
                    while (nums[i] == 1)
                    {
                        count++;
                        if (i < nums.Length - 1)
                        {
                            i++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                isOne.Add(count);
            }
            return isOne.Max();
        }
    }
}
