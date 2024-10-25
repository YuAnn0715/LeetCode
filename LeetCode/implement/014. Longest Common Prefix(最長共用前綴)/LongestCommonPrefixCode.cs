using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LongestCommonPrefixCode : ILongestCommonPrefix
    {
        //14. Longest Common Prefix(最長公共前綴)
        public string LongestCommonPrefix(string[] strs)
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
    }
}
