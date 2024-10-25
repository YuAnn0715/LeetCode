using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class SearchInsertCode:ISearchInsert
    {
        //35. Search Insert Position(搜尋插入位置)
        public int SearchInsert(int[] nums, int target)
        {
            List<int> numsList = new List<int>(nums.ToList());
            if (numsList.Contains(target))
            {
                return (numsList.IndexOf(target));
            }
            else
            {
                numsList.Add(target);
                numsList.Sort();
                return (numsList.IndexOf(target));
            }
        }
    }
}
