using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class StrStrCode : IStrStr
    {
        public int StrStr(string haystack, string needle)
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
    }
}
