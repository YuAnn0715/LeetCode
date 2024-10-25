using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MySqrtCode : IMySqrt
    {
        //69. Sqrt(x)(平方x)
        public int MySqrt(int x)
        {
            if (x <= 1)
            {
                return x;
            }
            int start = 1;
            int end = x;
            int res = 0;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (mid <= x / mid)
                {
                    start = mid + 1;
                    res = mid;
                }
                else
                {
                    end = mid - 1;
                }
            }
            return res;
        }
    }
}
