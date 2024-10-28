using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class IsValidPalindromeCode : IIsValidPalindrome
    {
        //125. Valid Palindrome(有效回文)
        public bool IsValidPalindrome(string s)
        {
            if (s == "")
            {
                return true;
            }
            List<string> str = new List<string>();
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (char.IsLetterOrDigit(c))
                {
                    char lowerC = char.ToLower(c);
                    str.Add(lowerC.ToString());
                }
            }
            List<string> reStr = new List<string>(str);
            reStr.Reverse();

            string megStr = string.Join("", str);
            string megReStr = string.Join("", reStr);
            if (megStr == megReStr)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
