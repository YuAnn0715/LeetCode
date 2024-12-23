using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ValidPalindromeCode
    {
        public bool ValidPalindrome(string s)
        {
            char[] strings = s.ToCharArray();
            string reS = strings.Reverse().ToString();
            if (s == reS)
            {
                return true;
            }
            else
            {
                int halfIndex = s.Length / 2;
                for (int i = 0; i < length; i++)
                {

                }



            }
        }
    }
}
