using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class IsPowerOfTwoCode : IIsPowerOfTwo
    {
        //231. Power of Two(二的幕)
        public bool IsPowerOfTwo(int n)
        {
            if (n <= 0)
            {
                return false;
            }
            while (n % 2 == 0)
            {
                int n2 = n / 2;
                n = n2;
            }
            if (n != 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
