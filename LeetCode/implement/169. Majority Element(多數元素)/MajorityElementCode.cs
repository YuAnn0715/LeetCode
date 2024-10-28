using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MajorityElementCode:IMajorityElement
    {
        //169. Majority Element(多數元素)
        public int MajorityElement(int[] nums)
        {
            List<int> numList = new List<int>();
            foreach (var item in nums)
            {
                numList.Add(item);
            }
            numList.Sort();
            int overHalfNum = numList[0];
            if (numList.Count >= 3)
            {
                if (numList[numList.Count / 2] != overHalfNum)
                {
                    overHalfNum = numList[numList.Count / 2 + 1];
                }
            }
            return overHalfNum;
        }
    }
}
