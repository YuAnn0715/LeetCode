using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ContainsNearbyDuplicateCode : IContainsNearbyDuplicate
    {
        //219. Contains Duplicate II(包含重複項 二)
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, int> numIndices = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (numIndices.ContainsKey(nums[i]))
                {
                    if (i - numIndices[nums[i]] <= k)
                    {
                        return true;
                    }
                }
                numIndices[nums[i]] = i;
            }

            return false;
        }
    }
}
