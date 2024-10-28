using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ReverseVowelsCode : IReverseVowels
    {
        //345. Reverse Vowels of a String(字串母音反轉)
        public string ReverseVowels(string s)
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
    }
}
