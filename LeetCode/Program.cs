using System;
using System.Linq;
using System.Text;
using LeetCode;
using LeetCode.Service;
using LeetCode.test;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode
{
    class Solution
    {
        static void Main(string[] args)
        {
            // interface
            ITwoSum twoSum = new TwoSumCode();
            IIsPalindrome isPalindrome = new IsPalindromeCode();
            IRomanToInt romanToInt = new RomanToIntCode();
            ILongestCommonPrefix longestCommonPrefix = new LongestCommonPrefixCode();
            IIsValid isValid = new IsValidCode();
            IMergeTwoLists mergeTwoLists = new MergeTwoListsCode();
            IRemoveDuplicates removeDuplicates = new RemoveDuplicatesCode();
            IRemoveElement removeElement = new RemoveElementCode();
            IStrStr strStr = new StrStrCode();
            ISearchInsert searchInsert = new SearchInsertCode();
            ILengthOfLastWord lengthOfLastWord = new LengthOfLastWordCode();
            IPlusOne plusOne = new PlusOneCode();
            IAddBinary addBinary = new AddBinaryCode();
            IMySqrt mySqrt = new MySqrtCode();
            IClimbStairs climbStairs = new ClimbStairsCode();
            IMerge merge = new MergeCode();
            IMaxProfit maxProfit = new MaxProfitCode();
            IIsValidPalindrome isValidPalindrome = new IsValidPalindromeCode();
            ISingleNumber singleNumber = new SingleNumberCode();
            IConvertToTitle convertToTitle = new ConvertToTitleCode();
            IMajorityElement majorityElement = new MajorityElementCode();
            ITitleToNumber titleToNumber = new TitleToNumberCode();
            IReverseBits reverseBits = new ReverseBitsCode();
            IHammingWeight hammingWeight = new HammingWeightCode();
            IIsHappy isHappy = new IsHappyCode();
            IIsIsomorphic isIsomorphic = new IsIsomorphicCode();
            IContainsDuplicate containsDuplicate = new ContainsDuplicateCode();
            IContainsNearbyDuplicate containsNearbyDuplicate = new ContainsNearbyDuplicateCode();
            IIsPowerOfTwo isPowerOfTwo = new IsPowerOfTwoCode();
            IIsAnagram isAnagram = new IsAnagramCode();
            IAddDigits addDigits = new AddDigitsCode();
            IMissingNumber missingNumber = new MissingNumberCode();
            IIsPowerOfThree isPowerOfThree = new IsPowerOfThreeCode();
            ICountBits countBits = new CountBitsCode();
            IIsPowerOfFour isPowerOfFour = new IsPowerOfFourCode();
            IReverseString reverseString = new ReverseStringCode();
            IReverseVowels reverseVowels = new ReverseVowelsCode();
            IIntersection intersection = new IntersectionCode();
            IIntersect intersect = new IntersectCode();
            ICanConstruct canConstruct = new CanConstructCode();
            IFindTheDifference findTheDifference = new FindTheDifferenceCode();
            IIsSubsequence isSubsequence = new IsSubsequenceCode();
            IFizzBuzz fizzBuzz = new FizzBuzzCode();
            IFindDisappearedNumbers findDisappearedNumbers = new FindDisappearedNumbersCode();
            IFindContentChildren findContentChildren = new FindContentChildrenCode();
            IHammingDistance hammingDistance = new HammingDistanceCode();
            IFindComplement findComplement = new FindComplementCode();
            ILicenseKeyFormatting licenseKeyFormatting = new LicenseKeyFormattingCode();
            IFindMaxConsecutiveOnes findMaxConsecutiveOnes = new FindMaxConsecutiveOnesCode();
            IConstructRectangle constructRectangle = new ConstructRectangleCode();
            IFindPoisonedDuration findPoisonedDuration = new FindPoisonedDurationCode();

            Test test = new Test();
            //========================測試區=======================
            //1. Two Sum(兩數和)  *Submit完成
            test.twoSum(twoSum);

            //9. Palindrome Number(回文數)  *Submit完成
            test.isPalindrome(isPalindrome);

            //13. Roman to Integer(羅馬數字轉整數)  *Submit完成
            test.RomanToInt(romanToInt);

            //14. Longest Common Prefix(最長共用前綴)  *Submit完成
            test.LongestCommonPrefix(longestCommonPrefix);

            //20. Valid Parentheses(有效括號)  *Submit完成
            test.IsValid(isValid);

            //21. Merge Two Sorted Lists(合併兩個表)  *Submit完成
            test.MergeTwoLists(mergeTwoLists);

            //26.Remove Duplicates from Sorted Array(從排序數組中刪除重複項)  *Submit完成
            test.RemoveDuplicates(removeDuplicates);

            //27.Remove Element(刪除元素)  *Submit完成
            test.RemoveElement(removeElement);

            //28. Find the Index of the First Occurrence in a String(尋找字串中第一次出現的索引)  *Submit完成
            test.StrStr(strStr);

            //35. Search Insert Position(搜尋插入位置)  *Submit完成
            test.SearchInsert(searchInsert);

            //58. Length of Last Word(最後一個字的長度)  *Submit完成
            test.LengthOfLastWord(lengthOfLastWord);

            //66. Plus One(加一)  *Submit完成
            test.PlusOne(plusOne);

            //67. Add Binary(新增二進位)  *Submit完成
            test.AddBinary(addBinary);

            //69. Sqrt(x)(平方x)   *Submit完成
            test.MySqrt(mySqrt);

            //70. Climbing Stairs(爬樓梯)  *Submit完成
            test.ClimbStairs(climbStairs);

            //88. Merge Sorted Array(合併排序數組)  *Submit完成
            test.Merge(merge);

            //121. Best Time to Buy and Sell Stock(買賣股票的最佳時機)  *Submit完成
            test.MaxProfit(maxProfit);

            //125. Valid Palindrome(有效回文)  *Submit完成
            test.IsValidPalindrome(isValidPalindrome);

            //136. Single Number(單號)  *Submit完成
            test.SingleNumber(singleNumber);

            //168. Excel Sheet Column Title(Excel 工作表列標題)  *Submit完成
            test.ConvertToTitle(convertToTitle);

            //169. Majority Element(多數元素)  *Submit完成
            test.MajorityElement(majorityElement);

            //171. Excel Sheet Column Number(Excel 工作表列號)  *Submit完成
            test.TitleToNumber(titleToNumber);

            //190. Reverse Bits(反轉位)  *Submit完成
            test.ReverseBits(reverseBits);

            //191. Number of 1 Bits(1 位數)  *Submit完成
            test.HammingWeight(hammingWeight);

            //202. Happy Number(快樂數)  *Submit完成
            test.IsHappy(isHappy);

            //205. Isomorphic Strings(同構弦)  *Submit完成
            test.IsIsomorphic(isIsomorphic);

            //217. Contains Duplicate(包含重複項)  *Submit完成
            test.ContainsDuplicate(containsDuplicate);

            //219. Contains Duplicate II(包含重複項 二)  *Submit完成
            test.ContainsNearbyDuplicate(containsNearbyDuplicate);

            //231. Power of Two(二的幕)   *Submit完成
            test.IsPowerOfTwo(isPowerOfTwo);

            //242. Valid Anagram(有效的字謎詞)   *Submit完成
            test.IsAnagram(isAnagram);

            //258. Add Digits(添加數字)   *Submit完成
            test.AddDigits(addDigits);

            //268. Missing Number(缺號碼)   *Submit完成
            test.MissingNumber(missingNumber);

            //326. Power of Three(三的幕)  *Submit完成
            test.IsPowerOfThree(isPowerOfThree);

            //338. Counting Bits(計數位)  *Submit完成
            test.CountBits(countBits);

            //342. Power of Four(四的幕)  *Submit完成
            test.IsPowerOfFour(isPowerOfFour);

            //344. Reverse String(反轉字串)  *Submit完成
            test.ReverseString(reverseString);

            //345. Reverse Vowels of a String(字串母音反轉)  *Submit完成
            test.ReverseVowels(reverseVowels);

            //349. Intersection of Two Arrays(兩個數組的交集)  *Submit完成
            test.Intersection(intersection);

            //350. Intersection of Two Arrays II(兩個數組的交集 II)  *Submit完成
            test.Intersect(intersect);

            //383. Ransom Note(勒索信)  *Submit完成
            test.CanConstruct(canConstruct);

            //389. Find the Difference(找出差異)  *Submit完成
            test.FindTheDifference(findTheDifference);

            //392. Is Subsequence(是否子序列)  *Submit完成
            test.IsSubsequence(isSubsequence);

            //412. Fizz Buzz(蜂鳴聲)  *Submit完成
            test.FizzBuzz(fizzBuzz);

            //448. Find All Numbers Disappeared in an Array(找出數組所有消失的數字)
            test.FindDisappearedNumbers(findDisappearedNumbers);

            //455. Assign Cookies(分配餅乾)  *Submit完成
            test.FindContentChildren(findContentChildren);

            //461. Hamming Distance(漢明距離)  *Submit完成
            test.HammingDistance(hammingDistance);

            //476. Number Complement(數補碼)  *Submit完成
            test.FindComplement(findComplement);

            //482. License Key Formatting(許可金鑰格式化)  *Submit完成
            test.LicenseKeyFormatting(licenseKeyFormatting);

            //485. Max Consecutive Ones(最大連續數)  *Submit完成
            test.FindMaxConsecutiveOnes(findMaxConsecutiveOnes);

            //485. Max Consecutive Ones(最大連續數)  *Submit完成
            test.ConstructRectangle(constructRectangle);

            //495. Teemo Attacking(提摩攻擊)  *Submit完成
            test.FindPoisonedDuration(findPoisonedDuration);

            //500. Keyboard Row(鍵盤列)   *Submit完成
            //string[] words = { "Hello", "Alaska", "Dad", "Peace" };
            //string[] result = FindWords(words);
            //foreach (string item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //504. Base 7(基礎7)  *Submit完成
            //int num = -7;
            //string result = ConvertToBase7(num);
            //Console.WriteLine(result);

            //506. Relative Ranks(相對排名)  *Submit完成
            //int[] score = { 10, 3, 8, 9, 4 };
            //string[] result = FindRelativeRanks(score);
            //foreach (string item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //520. Detect Capital(檢查大寫)  *Submit完成
            //string word = "USA";
            //bool result = DetectCapitalUse(word);
            //Console.WriteLine(result);

            //551. Student Attendance Record I(學生出勤記錄 I)  *Submit完成
            //string s = "ALLAPPL";
            //bool result=CheckRecord(s);
            //Console.WriteLine(result);

            //575. Distribute Candies(分發糖果)   *Submit完成
            //int[] candyType = { 1, 1, 2, 2, 3, 3 };
            //int result = DistributeCandies(candyType);
            //Console.WriteLine(result);

            //int n = 2;
            //int result = Fib(n);
            //Console.WriteLine(result);

        }
        //=====================解題區=======================
        //263.
        //public bool IsUgly(int n)
        //{
        //    if (n == 1 || n == 2 || n == 3 || n == 5)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        if (n % 2 == 0 || n % 3 == 0 )
        //        {

        //        }
        //    }
        //}
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

        //504 Base 7(基礎7)  *Submit完成
        static string ConvertToBase7(int num)
        {
            if (num == 0) return "0";
            bool isNegative = num < 0;
            num = Math.Abs(num);
            List<string> convertToBase7 = [];
            while (num > 0)
            {
                int remainder = num % 7;
                convertToBase7.Insert(0, remainder.ToString());
                num /= 7;
            }
            string result = string.Join("", convertToBase7);
            return isNegative ? "-" + result : result;
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

        //520. Detect Capital(檢查大寫)  *Submit完成
        static bool DetectCapitalUse(string word)
        {
            List<char> upWord = new List<char>();
            upWord = ['A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'];
            if (upWord.Contains(word[0]))
            {
                int upSum = 1;
                for (int i = 1; i < word.Length; i++)
                {
                    if (upWord.Contains(word[i]))
                    {
                        upSum++;
                    }
                }
                if (upSum == word.Length || upSum == 1)
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
                //都小寫
                for (int i = 1; i < word.Length; i++)
                {
                    if (upWord.Contains(word[i]))
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        //551. Student Attendance Record I(學生出勤記錄 I)   *Submit完成
        static bool CheckRecord(string s)
        {
            int sumA = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'A')
                {
                    sumA++;
                }
                if (s[i] == 'L')
                {
                    int sumL = 0;
                    while (i < s.Length)
                    {
                        if (s[i] == 'L')
                        {
                            i++;
                            sumL++;
                        }
                        else
                        {
                            i--;
                            break;
                        }
                    }
                    if (sumL >= 3)
                    {
                        return false;
                    }
                }
            }
            if (sumA >= 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //575. Distribute Candies(分發糖果)   *Submit完成
        static int DistributeCandies(int[] candyType)
        {
            int halfCandies = candyType.Length / 2;
            // 唯一元素HashSet
            HashSet<int> uniqueCandies = new HashSet<int>();

            // 計算不同type數量
            foreach (int candy in candyType)
            {
                uniqueCandies.Add(candy);
            }

            // 取糖果種類跟一半糖果 哪個最小 return
            // 如果糖果種類比吃一半小 那怎麼吃都只會只有種類數量 吃不到一半
            // 反之  一半的數量比種類小 那怎麼吃 都只能吃一半的量
            return Math.Min(uniqueCandies.Count, halfCandies);
        }

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