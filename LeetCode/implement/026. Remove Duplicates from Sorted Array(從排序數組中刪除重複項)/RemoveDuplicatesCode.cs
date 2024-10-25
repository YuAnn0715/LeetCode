using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class RemoveDuplicatesCode : IRemoveDuplicates
    {
        //26. Remove Duplicates from Sorted Array(從排序數組中刪除重複項)
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            else
            {
                int count = 1;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] != nums[count - 1])
                    {
                        nums[count] = nums[i];
                        count++;
                    }
                }
                return count;
            }
        }
    }
}
