using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class IsAnagramCode : IIsAnagram
    {
        //242. Valid Anagram(有效的字謎詞)
        public bool IsAnagram(string s, string t)
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
    }
}
