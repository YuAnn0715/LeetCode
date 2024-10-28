using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class FizzBuzzCode : IFizzBuzz
    {
        //412. Fizz Buzz(蜂鳴聲)
        public IList<string> FizzBuzz(int n)
        {
            List<string> nums = [];
            for (int i = 1; i < n + 1; i++)
            {
                nums.Add(i.ToString());
            }
            for (int i = 0; i < nums.Count; i++)
            {
                int num = Convert.ToInt32(nums[i]);
                if (num % 3 == 0 && num % 5 == 0)
                {
                    nums[i] = "FizzBuzz";
                }
                else if (num % 3 == 0)
                {
                    nums[i] = "Fizz";
                }
                else if (num % 5 == 0)
                {
                    nums[i] = "Buzz";
                }
                else
                {
                    continue;
                }
            }
            return nums;
        }
    }
}
