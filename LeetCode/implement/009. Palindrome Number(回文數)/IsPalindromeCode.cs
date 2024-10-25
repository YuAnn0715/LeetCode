using LeetCode.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class IsPalindromeCode : IIsPalindrome
    {
        //9. Palindrome Number(回文數)
        public bool IsPalindrome(int x)
        {
            //如果X大於等於0
            if (x >= 0)
            {
                //x轉型string
                string strX = x.ToString();
                //strX反轉建構 string需要字符數組(.ToArray())
                string reStr = new string(strX.Reverse().ToArray());
                if (strX == reStr)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
