using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ClimbStairsCode:IClimbStairs
    {
        //70. Climbing Stairs(爬樓梯)
        public int ClimbStairs(int n)
        {
            if (n <= 1)
                return 1;

            int prev1 = 1;
            int prev2 = 1;
            int current = 0;

            for (int i = 2; i <= n; i++)
            {
                current = prev1 + prev2;
                prev1 = prev2;
                prev2 = current;
            }

            return current;
        }
    }
}
