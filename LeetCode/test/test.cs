using LeetCode.Model;
using LeetCode.Service;
using System.Text;

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

        //125. Valid Palindrome(有效回文)
        public void IsValidPalindrome(IIsValidPalindrome leetCode)
        {
            string s = "A man, a plan, a canal:Panama";
            bool result = leetCode.IsValidPalindrome(s);
            Console.WriteLine($"125.Valid Palindrome 的答案是 {result}");
        }

        //136. Single Number(單號)
        public void SingleNumber(ISingleNumber leetCode)
        {
            int[] nums = { 2, 2, 1 };
            int result = leetCode.SingleNumber(nums);
            Console.WriteLine($"136.Single Number 的答案是 {result}");
        }

        //168. Excel Sheet Column Title(Excel 工作表列標題)
        public void ConvertToTitle(IConvertToTitle leetCode)
        {
            int columnNumber = 701;
            string result = leetCode.ConvertToTitle(columnNumber);
            Console.WriteLine($"168.Excel Sheet Column Title 的答案是 {result}");
        }

        //169. Majority Element(多數元素)
        public void MajorityElement(IMajorityElement leetCode)
        {
            int[] nums = { 2, 2, 1, 1, 1, 2, 2 };
            int result = leetCode.MajorityElement(nums);
            Console.WriteLine($"169.Majority Element 的答案是 {result}");
        }

        //171. Excel Sheet Column Number(Excel 工作表列號)
        public void TitleToNumber(ITitleToNumber leetCode)
        {
            string columnTitle = "ZY";
            int result = leetCode.TitleToNumber(columnTitle);
            Console.WriteLine($"171.Excel Sheet Column Number 的答案是 {result}");
        }

        //190. Reverse Bits(反轉位)
        public void ReverseBits(IReverseBits leetCode)
        {
            uint n = 000000101001010;
            uint result = leetCode.ReverseBits(n);
            Console.WriteLine($"190.Reverse Bits 的答案是 {result}");
        }

        //191. Number of 1 Bits(1 位數)
        public void HammingWeight(IHammingWeight leetCode)
        {
            uint n = 00000000000000000000000000001011;
            int result = leetCode.HammingWeight(n);
            Console.WriteLine($"191.Number of 1 Bits 的答案是 {result}");
        }

        //202. Happy Number(快樂數)
        public void IsHappy(IIsHappy leetCode)
        {
            int n = 19;
            bool result = leetCode.IsHappy(n);
            Console.WriteLine($"202.Happy Number 的答案是 {result}");
        }

        //205. Isomorphic Strings(同構弦)
        public void IsIsomorphic(IIsIsomorphic leetCode)
        {
            string s = "egg";
            string t = "add";
            bool result = leetCode.IsIsomorphic(s, t);
            Console.WriteLine($"205.Isomorphic Strings 的答案是 {result}");
        }

        //217. Contains Duplicate(包含重複項)
        public void ContainsDuplicate(IContainsDuplicate leetCode)
        {
            int[] nums = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            bool result = leetCode.ContainsDuplicate(nums);
            Console.WriteLine($"217.Contains Duplicate 的答案是 {result}");
        }

        //219. Contains Duplicate II(包含重複項 二)
        public void ContainsNearbyDuplicate(IContainsNearbyDuplicate leetCode)
        {
            int[] nums = { 1, 2, 3, 1 };
            int k = 3;
            bool result = leetCode.ContainsNearbyDuplicate(nums, k);
            Console.WriteLine($"219.Contains Duplicate 的答案是 {result}");
        }

        //231. Power of Two(二的幕)
        public void IsPowerOfTwo(IIsPowerOfTwo leetCode)
        {
            int n = 16;
            bool result = leetCode.IsPowerOfTwo(n);
            Console.WriteLine($"231.Power of Two 的答案是 {result}");
        }

        //242. Valid Anagram(有效的字謎詞)
        public void IsAnagram(IIsAnagram leetCode)
        {
            string s = "anagram";
            string t = "nagaram";
            bool result = leetCode.IsAnagram(s, t);
            Console.WriteLine($"242.Valid Anagram 的答案是 {result}");
        }

        //258. Add Digits(添加數字)
        public void AddDigits(IAddDigits leetCode)
        {
            int num = 38;
            int result = leetCode.AddDigits(num);
            Console.WriteLine($"258.Add Digits 的答案是 {result}");
        }

        //268. Missing Number(缺號碼)
        public void MissingNumber(IMissingNumber leetCode)
        {
            int[] nums = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
            int result = leetCode.MissingNumber(nums);
            Console.WriteLine($"268.Missing Number 的答案是 {result}");
        }

        //326. Power of Three(三的幕)
        public void IsPowerOfThree(IIsPowerOfThree leetCode)
        {
            int n = 27;
            bool result = leetCode.IsPowerOfThree(n);
            Console.WriteLine($"326.Power of Three 的答案是 {result}");
        }

        //338. Counting Bits(計數位)
        public void CountBits(ICountBits leetCode)
        {
            int n = 5;
            int[] result = leetCode.CountBits(n);
            Console.WriteLine($"338.Counting Bits 的答案是 {string.Join(", ", result)}");
        }

        //342. Power of Four(四的幕)
        public void IsPowerOfFour(IIsPowerOfFour leetCode)
        {
            int n = 16;
            bool result = leetCode.IsPowerOfFour(n);
            Console.WriteLine($"342.Power of Four 的答案是 {result}");
        }

        //344. Reverse String(反轉字串)
        public void ReverseString(IReverseString leetCode)
        {
            char[] s = { 'h', 'e', 'l', 'l', 'o' };
            char[] result = leetCode.ReverseString(s);
            Console.WriteLine($"344.Reverse String 的答案是 {string.Join(", ", result)}");
        }

        //345. Reverse Vowels of a String(字串母音反轉)
        public void ReverseVowels(IReverseVowels leetCode)
        {
            string s = "leetcode";
            string result = leetCode.ReverseVowels(s);
            Console.WriteLine($"345.Reverse Vowels of a String 的答案是 {result}");
        }

        //349. Intersection of Two Arrays(兩個數組的交集)
        public void Intersection(IIntersection leetCode)
        {
            int[] nums1 = { 4, 9, 5 };
            int[] nums2 = { 9, 4, 9, 8, 4 };
            int[] result = leetCode.Intersection(nums1, nums2);
            Console.WriteLine($"349.Intersection of Two Arrays 的答案是 {string.Join(", ", result)}");
        }

        //350. Intersection of Two Arrays II(兩個數組的交集 II)
        public void Intersect(IIntersect leetCode)
        {
            int[] nums1 = { 4, 9, 5 };
            int[] nums2 = { 9, 4, 9, 8, 4 };
            int[] result = leetCode.Intersect(nums1, nums2);
            Console.WriteLine($"350.Intersection of Two Arrays II 的答案是 {string.Join(", ", result)}");
        }

        //383. Ransom Note(勒索信)
        public void CanConstruct(ICanConstruct leetCode)
        {
            string ransomNote = "aa";
            string magazine = "ab";
            bool result = leetCode.CanConstruct(ransomNote, magazine);
            Console.WriteLine($"383.Ransom Note 的答案是 {result}");
        }

        //389. Find the Difference(找出差異)
        public void FindTheDifference(IFindTheDifference leetCode)
        {
            string s = "abcd";
            string t = "abcde";
            char result = leetCode.FindTheDifference(s, t);
            Console.WriteLine($"389.Find the Difference 的答案是 {result}");
        }

        //392. Is Subsequence(是否子序列)
        public void IsSubsequence(IIsSubsequence leetCode)
        {
            string s = "axc";
            string t = "ahbgdc";
            bool result = leetCode.IsSubsequence(s, t);
            Console.WriteLine($"392.Is Subsequence 的答案是 {result}");
        }

        //412. Fizz Buzz(蜂鳴聲)
        public void FizzBuzz(IFizzBuzz leetCode)
        {
            int n = 15;
            IList<string> result = leetCode.FizzBuzz(n);
            Console.WriteLine($"412.Fizz Buzz 的答案是 {string.Join(", ", result)}");
        }

        //448. Find All Numbers Disappeared in an Array(找出數組中所有消失的數字)
        public void FindDisappearedNumbers(IFindDisappearedNumbers leetCode)
        {
            int[] nums = { 4, 3, 2, 7, 8, 2, 3, 1 };
            IList<int> result = leetCode.FindDisappearedNumbers(nums);
            Console.WriteLine($"448.Find All Numbers Disappeared in an Array 的答案是 {string.Join(", ", result)}");
        }

        //455. Assign Cookies(分配餅乾)
        public void FindContentChildren(IFindContentChildren leetCode)
        {
            int[] g = { 3, 2, 1 };
            int[] s = { 1, 1 };
            int result = leetCode.FindContentChildren(g, s);
            Console.WriteLine($"455.Assign Cookies 的答案是 {result}");
        }

        //461. Hamming Distance(漢明距離)
        public void HammingDistance(IHammingDistance leetCode)
        {
            int x = 1;
            int y = 4;
            int result = leetCode.HammingDistance(x, y);
            Console.WriteLine($"461.Hamming Distance 的答案是 {result}");
        }

        //476. Number Complement(數補碼)
        public void FindComplement(IFindComplement leetCode)
        {
            int num = 5;
            int result = leetCode.FindComplement(num);
            Console.WriteLine($"476.Number Complement 的答案是 {result}");
        }

        //482. License Key Formatting(許可金鑰格式化)
        public void LicenseKeyFormatting(ILicenseKeyFormatting leetCode)
        {
            string s = "--a-a-a-a--";
            int k = 2;
            string result = leetCode.LicenseKeyFormatting(s, k);
            Console.WriteLine($"482.License Key Formatting 的答案是 {result}");
        }

        //485. Max Consecutive Ones(最大連續數)
        public void FindMaxConsecutiveOnes(IFindMaxConsecutiveOnes leetCode)
        {
            int[] nums = { 1, 1, 0, 1, 1, 1 };
            int result = leetCode.FindMaxConsecutiveOnes(nums);
            Console.WriteLine($"485.Max Consecutive Ones 的答案是 {result}");
        }

        //492. Construct the Rectangle(構造矩形)
        public void ConstructRectangle(IConstructRectangle leetCode)
        {
            int area = 37;
            int[] result = leetCode.ConstructRectangle(area);
            Console.WriteLine($"492.Construct the Rectangle 的答案是 {string.Join(", ", result)}");
        }

        //495. Teemo Attacking(提摩攻擊)
        public void FindPoisonedDuration(IFindPoisonedDuration leetCode)
        {
            int[] timeSeries = { 1, 3, 5, 7, 9, 11, 13, 15 };
            int duration = 3;
            int result = leetCode.FindPoisonedDuration(timeSeries, duration);
            Console.WriteLine($"495.Teemo Attacking 的答案是 {result}");
        }

        //500. Keyboard Row(鍵盤列)
        public void FindWords(IFindWords leetCode)
        {
            string[] words = { "Hello", "Alaska", "Dad", "Peace" };
            string[] result = leetCode.FindWords(words);
            Console.WriteLine($"500.Keyboard Row 的答案是 {string.Join(", ", result)}");
        }

        //504. Base 7(基礎7)
        public void ConvertToBase7(IConvertToBase7 leetCode)
        {
            int num = -7;
            string result = leetCode.ConvertToBase7(num);
            Console.WriteLine($"504.Base 7 的答案是 {result}");
        }

        //506. Relative Ranks(相對排名)
        public void FindRelativeRanks(IFindRelativeRanks leetCode)
        {
            int[] score = { 10, 3, 8, 9, 4 };
            string[] result = leetCode.FindRelativeRanks(score);
            Console.WriteLine($"506.Relative Ranks 的答案是 {string.Join(", ", result)}");
        }

        //520. Detect Capital(檢查大寫)
        public void DetectCapitalUse(IDetectCapitalUse leetCode)
        {
            string word = "USA";
            bool result = leetCode.DetectCapitalUse(word);
            Console.WriteLine($"520.Detect Capital 的答案是 {result}");
        }

        //551. Student Attendance Record I(學生出勤記錄 I)
        public void CheckRecord(ICheckRecord leetCode)
        {
            string s = "ALLAPPL";
            bool result = leetCode.CheckRecord(s);
            Console.WriteLine($"551.Student Attendance Record I 的答案是 {result}");
        }

        //557. Reverse Words in a String III(反轉字串中的文字 III)
        public void ReverseWords(IReverseWords leetCode)
        {
            string s = "Let's take LeetCode contest";
            string result = leetCode.ReverseWords(s);
            Console.WriteLine($"557.Reverse Words in a String III(反轉字串中的文字 III) 的答案是 {result}");
        }

        //575. Distribute Candies(分發糖果)
        public void DistributeCandies(IDistributeCandies leetCode)
        {
            int[] candyType = { 1, 1, 2, 2, 3, 3 };
            int result = leetCode.DistributeCandies(candyType);
            Console.WriteLine($"575.Distribute Candies(分發糖果) 的答案是 {result}");
        }
    }
}
