using LeetCode.Model;
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
            int[] result = leetCode.TwoSum(nums, target);
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

        //21. Merge Two Sorted Lists(合併兩個表)
        public void MergeTwoLists(IMergeTwoLists leetCode)
        {
            ListNode list1 = new(1, 2, 4);
            ListNode list2 = new(1, 3, 4);
            ListNode result = leetCode.MergeTwoLists(list1, list2);
            StringBuilder sb = new StringBuilder();
            ListNode current = result;
            while (current != null)
            {
                sb.Append(current.val);
                if (current.next != null)
                {
                    sb.Append(", ");
                }
                current = current.next;
            }
            Console.WriteLine($"21.Merge Two Sorted Lists 的答案是{sb.ToString()}");
        }

        //26. Remove Duplicates from Sorted Array(從排序數組中刪除重複項)
        public void RemoveDuplicates(IRemoveDuplicates leetCode)
        {
            int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int result = leetCode.RemoveDuplicates(nums);
            Console.WriteLine($"26.Remove Duplicates from Sorted Array 的答案是 {result}");
        }

        //27. Remove Element(刪除元素)
        public void RemoveElement(IRemoveElement leetCode)
        {
            int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2 };
            int val = 2;
            int result = leetCode.RemoveElement(nums, val);
            Console.WriteLine($"27.Remove Element 的答案是 {result}");
        }

        //28. Find the Index of the First Occurrence in a String(尋找字串中第一次出現的索引)
        public void StrStr(IStrStr leetCode)
        {
            string haystack = "sadbutsad";
            string needle = "sad";
            int result = leetCode.StrStr(haystack, needle);
            Console.WriteLine($"28.Find the Index of the First Occurrence in a String 的答案是 {result}");
        }

        //35. Search Insert Position(搜尋插入位置)
        public void SearchInsert(ISearchInsert leetCode)
        {
            int[] nums = { 1, 3, 5, 6 };
            int target = 5;
            int result = leetCode.SearchInsert(nums, target);
            Console.WriteLine($"35.Search Insert Position 的答案是 {result}");
        }

        //58. Length of Last Word(最後一個字的長度)
        public void LengthOfLastWord(ILengthOfLastWord leetCode)
        {
            string s = "fly me to the Moon";
            int result = leetCode.LengthOfLastWord(s);
            Console.WriteLine($"58.Length of Last Word 的答案是 {result}");
        }

        //66. Plus One(加一)
        public void PlusOne(IPlusOne leetCode)
        {
            int[] digits = { 1, 2, 3 };
            int[] result = leetCode.PlusOne(digits);
            Console.WriteLine($"66.Plus One 的答案是 {string.Join(", ", result)}");
        }

        //67. Add Binary(新增二進位)
        public void AddBinary(IAddBinary leetCode)
        {
            string a = "1010";
            string b = "1011";
            string result = leetCode.AddBinary(a, b);
            Console.WriteLine($"67.Add Binary 的答案是 {result}");
        }

        //69. Sqrt(x)(平方x)
        public void MySqrt(IMySqrt leetCode)
        {
            int x = 8;
            int result = leetCode.MySqrt(x);
            Console.WriteLine($"69.Sqrt(x) 的答案是 {result}");
        }

        //70. Climbing Stairs(爬樓梯)
        public void ClimbStairs(IClimbStairs leetCode)
        {
            int n = 3;
            int result = leetCode.ClimbStairs(n);
            Console.WriteLine($"70.Climbing Stairs 的答案是 {result}");
        }

        //88. Merge Sorted Array(合併排序數組)
        public void Merge(IMerge leetCode)
        {
            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int[] nums2 = { 2, 5, 6 };
            int m = 3;
            int n = 3;
            int[] result = leetCode.Merge(nums1, m, nums2, n);
            Console.WriteLine($"88.Merge Sorted Array 的答案是 {string.Join(", ", result)}");
        }

        //121. Best Time to Buy and Sell Stock(買賣股票的最佳時機)
        public void MaxProfit(IMaxProfit leetCode)
        {
            int[] prices = { 7, 1, 5, 3, 6, 4 };
            int result = leetCode.MaxProfit(prices);
            Console.WriteLine($"121.Best Time to Buy and Sell Stock 的答案是 {result}");
        }
    }
}
