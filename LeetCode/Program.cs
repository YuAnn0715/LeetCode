using System;
using System.Linq;
using System.Text;
using LeetCode;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode
{
    //========================測試區=======================
    class Solution
    {
        static void Main(string[] args)
        {
            //1. Two Sum(兩數和)  *Submit完成
            //int[] nums = { 2, 7, 11, 15 };
            //int target = 9;
            //int[] result = TwoSum(nums, target);
            //foreach (int item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //9. Palindrome Number(回文數)  *Submit完成
            //int x = 121;
            //bool result = IsPalindrome(x);
            //Console.WriteLine(result);

            //13. Roman to Integer(羅馬數字轉整數)  *Submit完成
            //string s = "MCMXCIV";
            //int result = RomanToInt(s);
            //Console.WriteLine(result);

            //14. Longest Common Prefix(最長公共前綴)  *Submit完成
            //string[] strs = { "flower", "flow", "flight" };
            //string result = LongestCommonPrefix(strs);
            //Console.WriteLine(result);

            //20. Valid Parentheses(有效括號)  *Submit完成
            //string s = "()[]{}";
            //bool result = IsValid(s);
            //Console.WriteLine(result);

            //21. Merge Two Sorted Lists(合併兩個表)  *Submit完成
            //ListNode list1 = new ListNode(1, 2, 4);
            //ListNode list2 = new ListNode(1, 3, 4);
            //ListNode result = MergeTwoLists(list1, list2);
            //foreach (ListNode node in result)
            //{
            //    Console.WriteLine(node);
            //}

            //26.Remove Duplicates from Sorted Array(從排序數組中刪除重複項)  *Submit完成
            //int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            //int result = RemoveDuplicates(nums);
            //Console.WriteLine(result);

            //27.Remove Element(刪除元素)  *Submit完成
            //int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2 };
            //int val = 2;
            //int result = RemoveElement(nums,val);
            //Console.WriteLine(result);

            //28. Find the Index of the First Occurrence in a String(尋找字串中第一次出現的索引)  *Submit完成
            //string haystack = "sadbutsad";
            //string needle = "sad";
            //int result = StrStr(haystack, needle);
            //Console.WriteLine(result);

            //35. Search Insert Position(搜尋插入位置)  *Submit完成
            //int[] nums = { 1, 3, 5, 6 };
            //int target = 5;
            //int result = SearchInsert(nums, target);
            //Console.WriteLine(result);

            //58. Length of Last Word(最後一個字的長度)  *Submit完成
            //string s = "fly me to the Moon";
            //int result = LengthOfLastWord(s);
            //Console.WriteLine(result);

            //66. Plus One(加一)  *Submit完成
            //int[] digits = { 1, 2, 3 };
            //int[] result = PlusOne(digits);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //67. Add Binary(新增二進位)  *Submit完成
            //string a = "1010";
            //string b = "1011";
            //string result = AddBinary(a, b);
            //Console.WriteLine(result);

            //69. Sqrt(x)(平方x)   *Submit完成
            //int x = 8;
            //int result = MySqrt(x);
            //Console.WriteLine(result);

            //70. Climbing Stairs(爬樓梯)  *Submit完成
            //int n = 3;
            //int result = ClimbStairs(n);
            //Console.WriteLine(result);

            //88. Merge Sorted Array(合併排序數組)  *Submit完成
            //int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            //int[] nums2 = { 2, 5, 6 };
            //int m = 3;
            //int n = 3;
            //int[] result = Merge(nums1, m, nums2, n);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //121. Best Time to Buy and Sell Stock(買賣股票的最佳時機)  *Submit完成
            //int[] prices = { 7, 1, 5, 3, 6, 4 };
            //int result = MaxProfit(prices);
            //Console.WriteLine(result);

            //125. Valid Palindrome(有效回文)  *Submit完成
            //string s = "A man, a plan, a canal:Panama";
            //bool result = IsPalindrome(s);
            //Console.WriteLine(result);

            //136. Single Number(單號)  *Submit完成
            //int[] nums = { 2, 2, 1 };
            //int result = SingleNumber(nums);
            //Console.WriteLine(result);

            //168. Excel Sheet Column Title(Excel 工作表列標題)  *Submit完成
            //int columnNumber = 701;
            //string result = ConvertToTitle(columnNumber);
            //Console.WriteLine(result);

            //169. Majority Element(多數元素)  *Submit完成
            //int[] nums = { 2, 2, 1, 1, 1, 2, 2 };
            //int result = MajorityElement(nums);
            //Console.WriteLine(result);

            //171. Excel Sheet Column Number(Excel 工作表列號)  *Submit完成
            //string columnTitle = "ZY";
            //int result = TitleToNumber(columnTitle);
            //Console.WriteLine(result);

            //190. Reverse Bits(反轉位)  *Submit完成
            //uint n = 000000101001010;
            //uint result = reverseBits(n);
            //Console.WriteLine(result);

            //191. Number of 1 Bits(1 位數)  *Submit完成
            //uint n = 00000000000000000000000000001011;
            //int result = HammingWeight(n);
            //Console.WriteLine(result);

            //202. Happy Number(快樂數)  *Submit完成
            //int n = 19;
            //bool result = IsHappy(n);
            //Console.WriteLine(result);

            //205. Isomorphic Strings(同構弦)  *Submit完成
            //string s = "egg";
            //string t = "add";
            //bool result = IsIsomorphic(s, t);
            //Console.WriteLine(result);

            //217. Contains Duplicate(包含重複項)  *Submit完成
            //int[] nums = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            //bool result = ContainsDuplicate(nums);
            //Console.WriteLine(result);

            //219. 
            int[] nums = { 1, 2, 3, 1 };
            int k = 3;
            bool result = ContainsNearbyDuplicate(nums,k);
            Console.WriteLine(result);


            //231. Power of Two(二的幕)   *Submit完成
            //int n = 16;
            //bool result = IsPowerOfTwo(n);
            //Console.WriteLine(result);

            //242. Valid Anagram(有效的字謎詞)   *Submit完成
            //string s = "anagram";
            //string t = "nagaram";
            //bool result = IsAnagram(s, t);
            //Console.WriteLine(result);

            //258. Add Digits(添加數字)   *Submit完成
            //int num = 38;
            //int result = AddDigits(num);
            //Console.WriteLine(result);

            //268. Missing Number(缺號碼)   *Submit完成
            //int[] nums = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
            //int result = MissingNumber(nums);
            //Console.WriteLine(result);

            //326. Power of Three(三的幕)  *Submit完成
            //int n = 27;
            //bool result = IsPowerOfThree(n);
            //Console.WriteLine(result);

            //338. Counting Bits(計數位)  *Submit完成
            //int n = 5;
            //int[] result = CountBits(n);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //342. Power of Four(四的幕)  *Submit完成
            //int n = 16;
            //bool result= IsPowerOfFour(n);
            //Console.WriteLine(result);

            //344. Reverse String(反轉字串)  *Submit完成
            //char[] s = { 'h', 'e','l','l','o' };
            //char[] result = ReverseString(s);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //345. Reverse Vowels of a String(字串母音反轉)  *Submit完成
            //string s = "leetcode";
            //string result = ReverseVowels(s);
            //Console.WriteLine(result);

            //349. Intersection of Two Arrays(兩個數組的交集)  *Submit完成
            //int[] nums1 = { 4, 9, 5 };
            //int[] nums2 = { 9, 4, 9, 8, 4 };
            //int[] result = Intersection(nums1, nums2);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //350. Intersection of Two Arrays II(兩個數組的交集 II)  *Submit完成
            //int[] nums1 = { 4, 9, 5 };
            //int[] nums2 = { 9, 4, 9, 8, 4 };
            //int[] result = Intersect(nums1, nums2);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //383. Ransom Note(勒索信)  *Submit完成
            //string ransomNote = "aa";
            //string magazine = "ab";
            //bool result = CanConstruct(ransomNote, magazine);
            //Console.WriteLine(result);

            //389. Find the Difference(找出差異)  *Submit完成
            //string s = "abcd";
            //string t = "abcde";
            //char result= FindTheDifference(s, t);
            //Console.WriteLine(result);

            //392. Is Subsequence(是否子序列)  *Submit完成
            //string s = "axc";
            //string t = "ahbgdc";
            //bool result= IsSubsequence(s, t);
            //Console.WriteLine(result);

            //455. Assign Cookies(分配餅乾)  *Submit完成
            //int[] g = { 3, 2, 1 };
            //int[] s = { 1, 1 };
            //int result = FindContentChildren(g, s);
            //Console.WriteLine(result);

            //461. Hamming Distance(漢明距離)  *Submit完成
            //int x = 1;
            //int y = 4;
            //int result = HammingDistance(x, y);
            //Console.WriteLine(result);

            //476. Number Complement(數補碼)  *Submit完成
            //int num = 5;
            //int result = FindComplement(num);
            //Console.WriteLine(result);

            //482. License Key Formatting(許可金鑰格式化)  *Submit完成
            //string s = "--a-a-a-a--";
            //int k = 2;
            //string result = LicenseKeyFormatting(s, k);
            //Console.WriteLine(result);

            //485. Max Consecutive Ones(最大連續數)  *Submit完成
            //int[] nums = { 1, 1, 0, 1, 1, 1 };
            //int result = FindMaxConsecutiveOnes(nums);
            //Console.WriteLine(result);

            //485. Max Consecutive Ones(最大連續數)  *Submit完成
            //int area = 37;
            //int[] result = ConstructRectangle(area);
            //foreach (int item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //495. Teemo Attacking(提摩攻擊)  *Submit完成
            //int[] timeSeries = { 1, 3, 5, 7, 9, 11, 13, 15 };
            //int duration = 3;
            //int result = FindPoisonedDuration(timeSeries, duration);
            //Console.WriteLine(result);

            //500. Keyboard Row(鍵盤列)   *Submit完成
            //string[] words = { "Hello", "Alaska", "Dad", "Peace" };
            //string[] result = FindWords(words);
            //foreach (string item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //506. Relative Ranks(相對排名)  *Submit完成
            //int[] score = { 10, 3, 8, 9, 4 };
            //string[] result = FindRelativeRanks(score);
            //foreach (string item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //int n = 2;
            //int result = Fib(n);
            //Console.WriteLine(result);

        }

        //=====================解題區=======================

        //1. Two Sum(兩數和)  *Submit完成
        static int[] TwoSum(int[] nums, int target)
        {
            int aryCount = nums.Length;
            List<int> answer = new List<int>();
            int n = 0;
            for (int i = 0; i < aryCount; i++)
            {
                n++;
                for (int j = n; j < aryCount; j++)
                {
                    int targetNumber = nums[i] + nums[j];
                    if (targetNumber == target)
                    {
                        answer.Add(i);
                        answer.Add(j);
                        break;
                    }
                }
                n = i + 1;
            }
            return (answer.ToArray());
        }

        //9. Palindrome Number(回文數)  *Submit完成
        static bool IsPalindrome(int x)
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

        //13. Roman to Integer(羅馬數字轉整數)  *Submit完成
        static int RomanToInt(string s)
        {
            Dictionary<string, int> romanNumber = new Dictionary<string, int>();
            romanNumber.Add("I", 1);
            romanNumber.Add("V", 5);
            romanNumber.Add("X", 10);
            romanNumber.Add("L", 50);
            romanNumber.Add("C", 100);
            romanNumber.Add("D", 500);
            romanNumber.Add("M", 1000);
            int romanTotal = 0;
            List<string> strSList = s.Select(c => c.ToString()).ToList();
            if (strSList.Count > 1)
            {
                for (int i = 0; i < strSList.Count - 1; i++)
                {
                    if (strSList[i] == "I" && strSList[i + 1] == "V")
                    {
                        romanTotal += 4;
                        strSList.RemoveAt(i);
                        strSList.RemoveAt(i);
                        i--;
                    }
                    else if (strSList[i] == "I" && strSList[i + 1] == "X")
                    {
                        romanTotal += 9;
                        strSList.RemoveAt(i);
                        strSList.RemoveAt(i);
                        i--;
                    }
                    else if (strSList[i] == "X" && strSList[i + 1] == "L")
                    {
                        romanTotal += 40;
                        strSList.RemoveAt(i);
                        strSList.RemoveAt(i);
                        i--;
                    }
                    else if (strSList[i] == "X" && strSList[i + 1] == "C")
                    {
                        romanTotal += 90;
                        strSList.RemoveAt(i);
                        strSList.RemoveAt(i);
                        i--;
                    }
                    else if (strSList[i] == "C" && strSList[i + 1] == "D")
                    {
                        romanTotal += 400;
                        strSList.RemoveAt(i);
                        strSList.RemoveAt(i);
                        i--;
                    }
                    else if (strSList[i] == "C" && strSList[i + 1] == "M")
                    {
                        romanTotal += 900;
                        strSList.RemoveAt(i);
                        strSList.RemoveAt(i);
                        i--;
                    }
                }
            }
            foreach (string item in strSList)
            {
                if (romanNumber.ContainsKey(item))
                {
                    int romanNumberValue = romanNumber[item];
                    romanTotal += romanNumberValue;
                }
            }
            return (romanTotal);
        }

        //14. Longest Common Prefix(最長公共前綴)  *Submit完成
        static string LongestCommonPrefix(string[] strs)
        {
            string start = strs[0];
            for (int i = 0; i < strs.Length; i++)
            {
                while (!strs[i].StartsWith(start))
                {
                    start = start.Substring(0, start.Length - 1);
                }
            }
            if (start.Length != 0)
            {
                return start;
            }
            else
            {
                return "";
            }
        }

        //20. Valid Parentheses(有效括號)  *Submit完成
        static bool IsValid(string s)
        {
            List<string> input = s.Select(c => c.ToString()).ToList();
            if (input.Count > 1)
            {
                for (int i = 0; i < input.Count - 1; i++)
                {
                    if (input[i] == "(")
                    {
                        if (input[i + 1] == ")")
                        {
                            input.RemoveAt(i);
                            input.RemoveAt(i);
                            i = -1;
                        }
                    }
                    else if (input[i] == "[")
                    {
                        if (input[i + 1] == "]")
                        {
                            input.RemoveAt(i);
                            input.RemoveAt(i);
                            i = -1;
                        }
                    }
                    else if (input[i] == "{")
                    {
                        if (input[i + 1] == "}")
                        {
                            input.RemoveAt(i);
                            input.RemoveAt(i);
                            i = -1;
                        }
                    }
                }
                if (input.Count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        //21. Merge Two Sorted Lists(合併兩個表)  *Submit完成
        static ListNode? MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null)
            {
                return list2;
            }
            if (list2 == null)
            {
                return list1;
            }
            if (list1 == null && list2 == null)
            {
                return null;
            }
            ListNode result = new ListNode(0);
            ListNode current = result;

            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    list2 = list2.next;
                }
                current = current.next;
            }
            current.next = list1 ?? list2;
            return result.next;
        }

        //26. Remove Duplicates from Sorted Array(從排序數組中刪除重複項)  *Submit完成
        static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            else
            {
                int count = 1;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] != nums[count - 1])
                    {
                        nums[count] = nums[i];
                        count++;
                    }
                }
                return count;
            }
        }

        //27. Remove Element(刪除元素)  *Submit完成
        static int RemoveElement(int[] nums, int val)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[count] = nums[i];
                    count++;
                }
            }
            return count;
        }

        //28. Find the Index of the First Occurrence in a String(尋找字串中第一次出現的索引)  *Submit完成
        static int StrStr(string haystack, string needle)
        {
            if (haystack.Contains(needle))
            {
                List<string> haystackList = haystack.Select(c => c.ToString()).ToList();
                List<string> needleList = needle.Select(c => c.ToString()).ToList();
                if (haystackList.Count == 1 && needleList.Count == 1)
                {
                    return (0);
                }
                for (int i = 0; i < needleList.Count; i++)
                {
                    for (int j = 0; j < haystackList.Count; j++)
                    {
                        if (needleList[i] == haystackList[j])
                        {
                            if (haystack.Substring(j, needleList.Count) == needle)
                            {
                                return (j);
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                return (-1);
            }
            else
            {
                return (-1);
            }
        }

        //35. Search Insert Position(搜尋插入位置)  *Submit完成
        static int SearchInsert(int[] nums, int target)
        {
            List<int> numsList = new List<int>(nums.ToList());
            if (numsList.Contains(target))
            {
                return (numsList.IndexOf(target));
            }
            else
            {
                numsList.Add(target);
                numsList.Sort();
                return (numsList.IndexOf(target));
            }
        }

        //58. Length of Last Word(最後一個字的長度)  *Submit完成
        static int LengthOfLastWord(string s)
        {
            List<string> sSplit = s.Split(" ").ToList();
            for (int i = 0; i < sSplit.Count; i++)
            {
                if (sSplit[i] == "")
                {
                    sSplit.RemoveAt(i);
                    i--;
                }
                else
                {
                    continue;
                }
            }
            string lastWord = sSplit[sSplit.Count - 1];
            int lastWordLength = lastWord.Length;
            return (lastWordLength);
        }

        //66. Plus One(加一)  *Submit完成
        static int[] PlusOne(int[] digits)
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

        //67. Add Binary(新增二進位)  *Submit完成
        static string AddBinary(string a, string b)
        {
            int carry = 0;
            int i = a.Length - 1;
            int j = b.Length - 1;
            StringBuilder result = new StringBuilder();

            while (carry > 0 || i >= 0 || j >= 0)
            {
                int sum = carry;
                if (i >= 0)
                {
                    sum += Convert.ToInt32(a[i].ToString());
                    i--;
                }
                if (j >= 0)
                {
                    sum += Convert.ToInt32(b[j].ToString());
                    j--;
                }
                carry = sum / 2;
                int digit = sum % 2;
                result.Insert(0, digit);
            }
            return result.ToString();
        }

        //69. Sqrt(x)(平方x)   *Submit完成
        static int MySqrt(int x)
        {
            if (x <= 1)
            {
                return x;
            }
            int start = 1;
            int end = x;
            int res = 0;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (mid <= x / mid)
                {
                    start = mid + 1;
                    res = mid;
                }
                else
                {
                    end = mid - 1;
                }
            }
            return res;
        }

        //70. Climbing Stairs(爬樓梯)  *Submit完成
        static int ClimbStairs(int n)
        {
            if (n <= 1)
                return 1;

            int prev1 = 1;
            int prev2 = 1;
            int current = 0;

            for (int i = 2; i <= n; i++)
            {
                current = prev1 + prev2;
                prev1 = prev2;
                prev2 = current;
            }

            return current;
        }

        //83
        //static ListNode DeleteDuplicates(ListNode head)
        //{
            
        //}

        //88. Merge Sorted Array(合併排序數組)  *Submit完成
        static int[] Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1;
            int j = n - 1;
            int k = m + n - 1;

            while (i >= 0 && j >= 0)
            {
                if (nums1[i] > nums2[j])
                {
                    nums1[k] = nums1[i];
                    i--;
                }
                else
                {
                    nums1[k] = nums2[j];
                    j--;
                }
                k--;
            }
            while (j >= 0)
            {
                nums1[k] = nums2[j];
                j--;
                k--;
            }
            //配合測試案例修改
            return nums1;
        }

        //121. Best Time to Buy and Sell Stock(買賣股票的最佳時機)  *Submit完成
        static int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            int minPrice = int.MaxValue;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minPrice)
                {
                    minPrice = prices[i];
                }
                else if (prices[i] - minPrice > maxProfit)
                {
                    maxProfit = prices[i] - minPrice;
                }
            }
            return maxProfit;
        }

        //125. Valid Palindrome(有效回文)  *Submit完成
        static bool IsPalindrome(string s)
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

        //136. Single Number(單號)  *Submit完成
        static int SingleNumber(int[] nums)
        {
            var singleNumber = 0;
            foreach (var num in nums)
            {
                singleNumber ^= num;
            }
            return singleNumber;
        }

        //168. Excel Sheet Column Title(Excel 工作表列標題)  *Submit完成
        static string ConvertToTitle(int columnNumber)
        {
            StringBuilder result = new StringBuilder();
            while (columnNumber > 0)
            {
                columnNumber--;
                char letter = (char)('A' + (columnNumber % 26));
                result.Insert(0, letter);
                columnNumber /= 26;
            }
            return result.ToString();
        }

        //169. Majority Element(多數元素)  *Submit完成
        static int MajorityElement(int[] nums)
        {
            List<int> numList = new List<int>();
            foreach (var item in nums)
            {
                numList.Add(item);
            }
            numList.Sort();
            int overHalfNum = numList[0];
            if (numList.Count >= 3)
            {
                if (numList[numList.Count / 2] != overHalfNum)
                {
                    overHalfNum = numList[numList.Count / 2 + 1];
                }
            }
            return overHalfNum;
        }

        //171. Excel Sheet Column Number(Excel 工作表列號)  *Submit完成
        static int TitleToNumber(string columnTitle)
        {
            string word = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int sum = 0;
            int count = 0;
            for (int i = columnTitle.Length - 1; i >= 0; i--)
            {
                int index = word.IndexOf(columnTitle[i]) + 1;
                sum += (int)Math.Pow(26, count) * index;
                count++;
            }
            return sum;
        }

        //190. Reverse Bits(反轉位)  *Submit完成
        static uint reverseBits(uint n)
        {
            string binary = Convert.ToString(n, 2);
            List<string> strList1 = binary.Select(s => s.ToString()).ToList();
            List<string> strList2 = new List<string>();
            if (strList1.Count < 33)
            {
                for (int i = 0; i < 32 - strList1.Count; i++)
                {
                    strList2.Add("0");
                }
                foreach (string item in strList1)
                {
                    strList2.Add(item);
                }
            }
            strList2.Reverse();
            string newBinary = string.Join("", strList2);
            uint total = Convert.ToUInt32(newBinary, 2);
            return total;
        }

        //191. Number of 1 Bits(1 位數)  *Submit完成
        static int HammingWeight(uint n)
        {
            string s = Convert.ToString(n, 2);
            int total = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '1')
                {
                    total++;
                }
            }
            return total;
        }

        //202. Happy Number(快樂數)  *Submit完成
        static bool IsHappy(int n)
        {
            if (n == 1)
            {
                return true;
            }
            else
            {
                List<int> happyIntList = new List<int>();
                List<string> happyStrList = new List<string>();
                do
                {
                    happyStrList.Clear();
                    happyIntList.Clear();
                    string happyStr = n.ToString();
                    happyStrList = happyStr.Select(n => n.ToString()).ToList();
                    int total = 0;
                    foreach (string item in happyStrList)
                    {
                        happyIntList.Add(int.Parse(item));
                    }
                    for (int i = 0; i < happyIntList.Count; i++)
                    {
                        int pow = Convert.ToInt32(Math.Pow(happyIntList[i], 2));
                        total += pow;
                        n = total;
                    }
                } while (n > 6);
                if (n == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        //205. Isomorphic Strings(同構弦)  *Submit完成
        static bool IsIsomorphic(string s, string t)
        {

            if (s.Length != t.Length)
                return false;

            Dictionary<char, char> dic = new Dictionary<char, char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i]))
                {
                    if (dic[s[i]] != t[i])
                        return false;
                }
                else
                {
                    if (dic.ContainsValue(t[i]))
                        return false;
                    else
                        dic.Add(s[i], t[i]);
                }
            }
            return true;
        }

        //217. Contains Duplicate(包含重複項)  *Submit完成
        static bool ContainsDuplicate(int[] nums)
        {
            int add = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                add++;
                for (int j = add; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //219. Contains Duplicate II(包含重複 二)  *Submit完成
        static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, int> numIndices = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (numIndices.ContainsKey(nums[i]))
                {
                    if (i - numIndices[nums[i]] <= k)
                    {
                        return true;
                    }
                }
                numIndices[nums[i]] = i;
            }

            return false;
        }

        //231. Power of Two(二的幕)   *Submit完成
        static bool IsPowerOfTwo(int n)
        {
            if (n <= 0)
            {
                return false;
            }
            while (n % 2 == 0)
            {
                int n2 = n / 2;
                n = n2;
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

        //242. Valid Anagram(有效的字謎詞)   *Submit完成
        static bool IsAnagram(string s, string t)
        {
            string lowWord = "abcdefghijklmnopqrstuvwxyz";
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            for (int i = 0; i < s.Length; i++)
            {
                int index = lowWord.IndexOf(s[i]);
                list1.Add(index);
            }
            for (int i = 0; i < t.Length; i++)
            {
                int index = lowWord.IndexOf(t[i]);
                list2.Add(index);
            }
            list1.Sort();
            list2.Sort();
            string sort1 = string.Join("", list1);
            string sort2 = string.Join("", list2);
            if (sort1 == sort2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //258. Add Digits(添加數字)   *Submit完成
        static int AddDigits(int num)
        {
            if (num < 10)
            {
                return num;
            }
            else
            {
                do
                {
                    int total = 0;
                    string s = num.ToString();
                    List<string> sList = s.Select(c => c.ToString()).ToList();
                    List<int> numberList = new List<int>();
                    foreach (string item in sList)
                    {
                        int number = Convert.ToInt32(item);
                        numberList.Add(number);
                    }

                    for (int i = 0; i < numberList.Count; i++)
                    {
                        total += numberList[i];
                    }
                    num = total;
                }
                while (num > 9);
                return num;
            }
        }

        //268. Missing Number(缺號碼)   *Submit完成
        static int MissingNumber(int[] nums)
        {
            int missNumber = 0;
            for (int i = 0; i < nums.Length + 1; i++)
            {
                if (nums.Contains(i))
                {
                    continue;
                }
                else
                {
                    missNumber = i;
                    break;
                }

            }
            return missNumber;
        }

        //326. Power of Three(三的幕)  *Submit完成
        static bool IsPowerOfThree(int n)
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

        //338. Counting Bits(計數位)  *Submit完成
        static int[] CountBits(int n)
        {
            List<int> one = new List<int>();
            for (int i = 0; i < n + 1; i++)
            {
                string binary = Convert.ToString(i, 2);
                int countOne = 0;
                for (int j = 0; j < binary.Length; j++)
                {
                    if (binary[j] == '1')
                    {
                        countOne++;
                    }
                }
                one.Add(countOne);
            }
            return one.ToArray();
        }

        //342. Power of Four(四的幕)  *Submit完成
        static bool IsPowerOfFour(int n)
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

        //344. Reverse String(反轉字串)  *Submit完成
        static char[] ReverseString(char[] s)
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

        //345. Reverse Vowels of a String(字串母音反轉)  *Submit完成
        static string ReverseVowels(string s)
        {
            List<char> vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            List<int> index = new List<int>();

            List<string> charArray = s.Select(w => w.ToString()).ToList();
            for (int i = 0; i < s.Length; i++)
            {
                if (vowels.Contains(s[i]))
                {
                    index.Add(i);
                }
            }
            int left = 0;
            int right = index.Count - 1;
            while (left < right)
            {
                string change = charArray[index[left]];
                charArray[index[left]] = charArray[index[right]];
                charArray[index[right]] = change;
                left++;
                right--;
            }
            string answer = string.Join("", charArray);
            return answer;
        }

        //349. Intersection of Two Arrays(兩個數組的交集)  *Submit完成
        static int[] Intersection(int[] nums1, int[] nums2)
        {
            List<int> output = new List<int>();
            if (nums1.Length > nums2.Length)
            {
                for (int i = 0; i < nums2.Length; i++)
                {
                    if (nums1.Contains(nums2[i]))
                    {
                        output.Add(nums2[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < nums1.Length; i++)
                {
                    if (nums2.Contains(nums1[i]))
                    {
                        output.Add(nums1[i]);
                    }
                }
            }
            List<int> outputDistinct = output.Distinct().ToList();
            return outputDistinct.ToArray();
        }

        //350. Intersection of Two Arrays II(兩個數組的交集 II)  *Submit完成
        static int[] Intersect(int[] nums1, int[] nums2)
        {
            List<int> num1List = nums1.ToList();
            List<int> num2List = nums2.ToList();
            List<int> output = new List<int>();
            //少的去檢查多的
            if (num1List.Count > num2List.Count)
            {
                for (int i = 0; i < num2List.Count; i++)
                {
                    for (int j = 0; j < num1List.Count; j++)
                    {
                        if (num2List[i] == num1List[j])
                        {
                            output.Add(num2List[i]);
                            num1List.RemoveAt(j);
                            break;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < num1List.Count; i++)
                {
                    for (int j = 0; j < num2List.Count; j++)
                    {
                        if (num1List[i] == num2List[j])
                        {
                            output.Add(num1List[i]);
                            num2List.RemoveAt(j);
                            break;
                        }
                    }
                }
            }
            return output.ToArray();
        }

        //383. Ransom Note(勒索信)  *Submit完成
        static bool CanConstruct(string ransomNote, string magazine)
        {
            for (int i = 0; i < ransomNote.Length; i++)
            {
                for (int j = 0; j < magazine.Length; j++)
                {
                    if (ransomNote[i] == magazine[j])
                    {
                        ransomNote = ransomNote.Remove(i, 1);
                        magazine = magazine.Remove(j, 1);
                        i--;
                        break;
                    }
                }
            }
            if (ransomNote.Length != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //389. Find the Difference(找出差異)  *Submit完成
        static char FindTheDifference(string s, string t)
        {
            if (s == "")
            {
                return Convert.ToChar(t);
            }
            else
            {
                for (int i = 0; i < s.Length; i++)
                {
                    for (int j = 0; j < t.Length; j++)
                    {
                        if (s[i] == t[j])
                        {
                            s = s.Remove(i, 1);
                            t = t.Remove(j, 1);
                            i--;
                            break;
                        }
                    }
                }
                return Convert.ToChar(t);
            }
        }

        //392. Is Subsequence(是否子序列)  *Submit完成
        static bool IsSubsequence(string s, string t)
        {
            int i = 0, j = 0;
            while (i < s.Length && j < t.Length)
            {
                if (s[i] == t[j])
                {
                    i++;
                }
                j++;
            }
            return i == s.Length;
        }

        //455. Assign Cookies(分配餅乾)  *Submit完成
        static int FindContentChildren(int[] g, int[] s)
        {
            Array.Sort(g);
            Array.Sort(s);
            int carryG = 0;
            int carryS = 0;
            while (carryG < g.Length && carryS < s.Length)
            {
                if (g[carryG] <= s[carryS])
                {
                    carryG++;
                    carryS++;
                }
                else
                {
                    carryS++;
                }
            }
            return carryG;
        }

        //461. Hamming Distance(漢明距離)  *Submit完成
        static int HammingDistance(int x, int y)
        {
            string binaryX = Convert.ToString(x, 2);
            string binaryY = Convert.ToString(y, 2);
            int Hamming = 0;
            if (binaryX.Length >= binaryY.Length)
            {
                while (binaryY.Length < binaryX.Length)
                {
                    binaryY = binaryY.Insert(0, "0");
                }
            }
            else
            {
                while (binaryY.Length > binaryX.Length)
                {
                    binaryX = binaryX.Insert(0, "0");
                }
            }
            for (int i = 0; i < binaryX.Length; i++)
            {
                if (binaryX[i] != binaryY[i])
                {
                    Hamming++;
                }
            }
            return Hamming;
        }

        //476. Number Complement(數補碼)  *Submit完成
        static int FindComplement(int num)
        {
            string binary = Convert.ToString(num, 2);
            string complement = "";
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '0')
                {
                    complement += "1";
                }
                else
                {
                    complement += "0";
                }
            }
            return Convert.ToInt32(complement, 2);
        }

        //482. License Key Formatting(許可金鑰格式化)  *Submit完成
        static string LicenseKeyFormatting(string s, int k)
        {
            s = s.ToUpper();
            List<char> sList = s.ToList();
            for (int i = 0; i < sList.Count; i++)
            {
                if (sList[i] == '-')
                {
                    sList.RemoveAt(i);
                    i--;
                }
            }
            int quotient = sList.Count / k;
            int addcount = 0;
            if (sList.Count % k == 0)
            {
                for (int i = 1; i < quotient; i++)
                {
                    sList.Insert(k * i + addcount, '-');
                    addcount++;
                }
            }
            else
            {
                for (int i = 1; i <= quotient; i++)
                {
                    sList.Insert(sList.Count - k * i - addcount, '-');
                    addcount++;
                }
            }
            return string.Join("", sList);
        }

        //485. Max Consecutive Ones(最大連續數)  *Submit完成
        static int FindMaxConsecutiveOnes(int[] nums)
        {
            List<int> isOne = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int count = 0;
                if (nums[i] == 1)
                {
                    while (nums[i] == 1)
                    {
                        count++;
                        if (i < nums.Length - 1)
                        {
                            i++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                isOne.Add(count);
            }
            return isOne.Max();
        }

        //492. Construct the Rectangle(構造矩形)  *Submit完成
        static int[] ConstructRectangle(int area)
        {
            int w = (int)Math.Sqrt(area);
            while (area % w != 0)
            {
                w--;
            }
            return [area / w, w];
        }


        //495. Teemo Attacking(提摩攻擊)  *Submit完成
        static int FindPoisonedDuration(int[] timeSeries, int duration)
        {
            int secondCount = 0;
            for (int i = 0; i < timeSeries.Length; i++)
            {
                //最後結束
                if (i == timeSeries.Length - 1)
                {
                    secondCount += duration;
                    break;
                }
                else
                {
                    if (timeSeries[i] + duration <= timeSeries[i + 1])
                    {
                        secondCount += duration;

                    }
                    else
                    {
                        //間隔
                        secondCount += timeSeries[i + 1] - timeSeries[i];
                    }
                }
            }
            return secondCount;
        }

        //500. Keyboard Row(鍵盤列)   *Submit完成
        static string[] FindWords(string[] words)
        {
            string firstRow = "qwertyuiopQWERTYUIOP";
            string secondRow = "asdfghjklASDFGHJKL";
            string thirdRow = "zxcvbnmZXCVBNM";
            List<string> answer = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                if (firstRow.Contains(words[i][0]))
                {
                    int count = 0;
                    for (int j = 0; j < words[i].Length; j++)
                    {
                        if (!firstRow.Contains(words[i][j]))
                        {
                            break;
                        }
                        else
                        {
                            count++;
                        }
                        if (count == words[i].Length)
                        {
                            answer.Add(words[i]);
                        }
                    }
                }
                else if (secondRow.Contains(words[i][0]))
                {
                    int count = 0;
                    for (int j = 0; j < words[i].Length; j++)
                    {
                        if (!secondRow.Contains(words[i][j]))
                        {
                            break;
                        }
                        else
                        {
                            count++;
                        }
                        if (count == words[i].Length)
                        {
                            answer.Add(words[i]);
                        }
                    }
                }
                else if (thirdRow.Contains(words[i][0]))
                {
                    int count = 0;
                    for (int j = 0; j < words[i].Length; j++)
                    {
                        if (!thirdRow.Contains(words[i][j]))
                        {
                            break;
                        }
                        else
                        {
                            count++;
                        }
                        if (count == words[i].Length)
                        {
                            answer.Add(words[i]);
                        }
                    }
                }
            }
            return answer.ToArray();
        }

        //506. Relative Ranks(相對排名)  *Submit完成
        static string[] FindRelativeRanks(int[] score)
        {
            List<string> rankList = new List<string>();
            for (int i = 0; i < score.Length; i++)
            {
                int point = 0;
                for (int j = 0; j < score.Length; j++)
                {
                    if (score[i] >= score[j])
                    {
                        point++;
                    }
                }
                int rank = score.Length + 1 - point;
                rankList.Add(rank.ToString());
            }
            for (int i = 0; i < rankList.Count; i++)
            {
                string rank = rankList[i];
                int topThree = 0;
                switch (rank)
                {
                    case "1":
                        rankList[i] = "Gold Medal";
                        topThree++;
                        break;
                    case "2":
                        rankList[i] = "Silver Medal";
                        topThree++;
                        break;
                    case "3":
                        rankList[i] = "Bronze Medal";
                        topThree++;
                        break;
                    default:
                        break;
                }
                if (topThree == 3)
                {
                    break;
                }
            }
            return rankList.ToArray();
        }

        //509. Fibonacci Number()
        //static int Fib(int n)
        //{
            
        //}

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }
}