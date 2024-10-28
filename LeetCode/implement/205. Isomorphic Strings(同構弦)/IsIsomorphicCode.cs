using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class IsIsomorphicCode : IIsIsomorphic
    {
        //205. Isomorphic Strings(同構弦)
        public bool IsIsomorphic(string s, string t)
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
    }
}
