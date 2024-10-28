using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public interface IFindDisappearedNumbers
    {
        //448. Find All Numbers Disappeared in an Array(找出數組中所有消失的數字)
        IList<int> FindDisappearedNumbers(int[] nums);
    }
}
