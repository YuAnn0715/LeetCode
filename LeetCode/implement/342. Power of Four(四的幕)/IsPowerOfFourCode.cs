using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class IsPowerOfFourCode : IIsPowerOfFour
    {
        //342. Power of Four(四的幕)
        public bool IsPowerOfFour(int n)
        {
            if (n <= 0)
            {
                return false;
            }
            else
            {
                while (n % 4 == 0)
                {
                    int n4 = n / 4;
                    n = n4;
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
}
