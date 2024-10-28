using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class FindContentChildrenCode : IFindContentChildren
    {
        //455. Assign Cookies(分配餅乾)
        public int FindContentChildren(int[] g, int[] s)
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
    }
}
