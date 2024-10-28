using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class FindTheDifferenceCode : IFindTheDifference
    {
        //389. Find the Difference(找出差異)
        public char FindTheDifference(string s, string t)
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
    }
}
