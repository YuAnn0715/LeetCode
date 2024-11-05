using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode
{
    public class MaximumProductCode : IMaximumProduct
    {
        //628. Maximum Product of Three Numbers (三個數的最大乘積)
        public int MaximumProduct(int[] nums)
        {
            //整數最大數相乘 or 有負數=>最小兩個負數*最大整數 = 最大乘積
            Array.Sort(nums);
            int allPositiveNumber = nums[nums.Length - 1] * nums[nums.Length - 2] * nums[nums.Length - 3];
            int haveNegativeNumber= nums[0] * nums[1] * nums[nums.Length - 1];
            return Math.Max(allPositiveNumber, haveNegativeNumber);
        }
    }
}
