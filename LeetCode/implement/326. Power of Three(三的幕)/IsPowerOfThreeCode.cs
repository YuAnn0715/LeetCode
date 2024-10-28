using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class IsPowerOfThreeCode : IIsPowerOfThree
    {
        //326. Power of Three(三的幕)
        public bool IsPowerOfThree(int n)
        {
            if (n <= 0)
            {
                return false;
            }
            while (n % 3 == 0)
            {
                int n3 = n / 3;
                n = n3;
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
