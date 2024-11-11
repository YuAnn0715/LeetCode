using System;
using System.Linq;
using System.Text;
using LeetCode;
using LeetCode.Service;
using LeetCode.test;

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
            IFindWords findWords = new FindWordsCode();
            IConvertToBase7 convertToBase7 = new ConvertToBase7Code();
            IFindRelativeRanks findRelativeRanks = new FindRelativeRanksCode();
            IDetectCapitalUse detectCapitalUse = new DetectCapitalUseCode();
            ICheckRecord checkRecord = new CheckRecordCode();
            IDistributeCandies distributeCandies = new DistributeCandiesCode();
            IReverseWords reverseWords = new ReverseWordsCode();
            IFindRestaurant findRestaurant = new FindRestaurantCode();
            IMaximumProduct maximumProduct = new MaximumProductCode();
            IFindErrorNums findErrorNums = new FindErrorNumsCode();
            IToLowerCase toLowerCase = new ToLowerCaseCode();

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

            //500. Keyboard Row(鍵盤列)  *Submit完成
            test.FindWords(findWords);

            //504. Base 7(基礎7)  *Submit完成
            test.ConvertToBase7(convertToBase7);

            //506. Relative Ranks(相對排名)  *Submit完成
            test.FindRelativeRanks(findRelativeRanks);

            //520. Detect Capital(檢查大寫)  *Submit完成
            test.DetectCapitalUse(detectCapitalUse);

            //551. Student Attendance Record I(學生出勤記錄 I)  *Submit完成
            test.CheckRecord(checkRecord);

            //557. Reverse Words in a String III(反轉字串中的文字 III)  *Submit完成
            test.ReverseWords(reverseWords);

            //575. Distribute Candies(分發糖果)  *Submit完成
            test.DistributeCandies(distributeCandies);

            //599. Minimum Index Sum of Two Lists (兩個集合的最小索引和)  *Submit完成
            test.FindRestaurant(findRestaurant);

            //628. Maximum Product of Three Numbers (三個數的最大乘積)  *Submit完成
            test.MaximumProduct(maximumProduct);

            //645. Set Mismatch(設定不匹配)  *Submit完成
            test.FindErrorNums(findErrorNums);

            //709. To Lower Case(轉小寫)  *Submit完成
            test.ToLowerCase(toLowerCase);
        }
    }
}