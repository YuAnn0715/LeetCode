using LeetCode.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TwoSumCode: ITwoSum
    {
        //1. Two Sum(兩數和)
        public int[] TwoSum(int[] nums, int target)
        {
            int aryCount = nums.Length;
            List<int> answer = new List<int>();
            int n = 0;
            for (int i = 0; i < aryCount; i++)
            {
                n++;
                for (int j = n; j < aryCount; j++)
                {
                    int targetNumber = nums[i] + nums[j];
                    if (targetNumber == target)
                    {
                        answer.Add(i);
                        answer.Add(j);
                        break;
                    }
                }
                n = i + 1;
            }
            return (answer.ToArray());
        }
    }
}
