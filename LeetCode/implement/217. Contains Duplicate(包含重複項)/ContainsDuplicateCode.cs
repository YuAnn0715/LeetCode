using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ContainsDuplicateCode : IContainsDuplicate
    {
        //217. Contains Duplicate(包含重複項)
        public bool ContainsDuplicate(int[] nums)
        {
            Dictionary<int, int> numIndices = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (numIndices.ContainsKey(nums[i]))
                {
                    return true;
                }
                numIndices[nums[i]] = i;
            }

            return false;
        }
    }
}
