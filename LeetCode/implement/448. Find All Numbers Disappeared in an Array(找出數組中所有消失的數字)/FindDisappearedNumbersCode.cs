using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class FindDisappearedNumbersCode : IFindDisappearedNumbers
    {
        //448. Find All Numbers Disappeared in an Array(找出數組中所有消失的數字)
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            List<int> missNums = [];
            for (int i = 1; i < nums.Length + 1; i++)
            {
                if (!nums.Contains(i))
                {
                    missNums.Add(i);
                }
            }
            return missNums;
        }
    }
}
