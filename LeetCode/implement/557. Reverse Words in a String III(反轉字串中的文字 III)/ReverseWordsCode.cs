using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ReverseWordsCode : IReverseWords
    {
        //557. Reverse Words in a String III(反轉字串中的文字 III)
        public string ReverseWords(string s)
        {
            string[] words = s.Split(' ');
            // 反轉每個單詞
            for (int i = 0; i < words.Length; i++)
            {
                char[] charArray = words[i].ToCharArray();
                Array.Reverse(charArray);
                words[i] = new string(charArray);
            }
            List<string> cutWords = new List<string>(words);
            string reverseWords = string.Join(" ", cutWords);
            return reverseWords;
        }
    }
}
