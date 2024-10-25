using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class PlusOneCode:IPlusOne
    {
        //66. Plus One(加一)
        public int[] PlusOne(int[] digits)
        {
            if (digits[digits.Length - 1] != 9)
            {
                digits[digits.Length - 1] = digits[digits.Length - 1] + 1;
                return digits;
            }
            else
            {
                int nineCount = 0;
                int nineEnd = 0;
                for (int i = digits.Length - 1; i >= 0; i--)
                {
                    if (digits[i] == 9)
                    {
                        nineCount++;
                    }
                    else
                    {
                        nineEnd = i;
                        break;
                    }
                }
                if (nineEnd == 0 && digits[0] == 9)
                {
                    List<int> digitsList = new List<int>();
                    digitsList.Add(1);
                    for (int i = 1; i < nineCount + 1; i++)
                    {
                        digitsList.Add(0);
                    }
                    return digitsList.ToArray();
                }
                else
                {
                    digits[nineEnd] = digits[nineEnd] + 1;
                    for (int i = 0; i < nineCount; i++)
                    {
                        digits[digits.Length - 1 - i] = 0;
                    }
                    return digits;
                }
            }
        }
    }
}
