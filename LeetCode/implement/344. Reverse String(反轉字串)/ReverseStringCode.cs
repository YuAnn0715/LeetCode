using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ReverseStringCode : IReverseString
    {
        //344. Reverse String(反轉字串)
        public char[] ReverseString(char[] s)
        {
            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {
                char change = s[left];
                s[left] = s[right];
                s[right] = change;
                left++;
                right--;
            }
            return s;
        }
    }
}
