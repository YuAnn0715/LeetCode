using LeetCode.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.test
{
    // 測試區
    public class Test
    {
        //1. Two Sum(兩數和)
        public void twoSum(ITwoSum leetCode)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] result= leetCode.TwoSum(nums, target);
            Console.WriteLine($"1.Two Sum 的答案是 {string.Join(", ", result)}");
        }

        //9. Palindrome Number(回文數)
        public void isPalindrome(IIsPalindrome leetCode)
        {
            int x = 121;
            bool result = leetCode.IsPalindrome(x);
            Console.WriteLine($"9.Palindrome Number 的答案是 {result}");
        }

        //13. Roman to Integer(羅馬數字轉整數)
        public void RomanToInt(IRomanToInt leetCode)
        {
            string s = "MCMXCIV";
            int result = leetCode.RomanToInt(s);
            Console.WriteLine($"13.Roman To Int 的答案是 {result}");
        }

        //14. Longest Common Prefix(最長公共前綴)
        public void LongestCommonPrefix(ILongestCommonPrefix leetCode)
        {
            string[] strs = { "flower", "flow", "flight" };
            string result = leetCode.LongestCommonPrefix(strs);
            Console.WriteLine($"14.Longest Common Prefix 的答案是 {result}");
        }

        //20. Valid Parentheses(有效括號)
        public void IsValid(IIsValid leetCode)
        {
            string s = "()[]{}";
            bool result = leetCode.IsValid(s);
            Console.WriteLine($"20.Valid Parentheses 的答案是 {result}");
        }
    }
}
