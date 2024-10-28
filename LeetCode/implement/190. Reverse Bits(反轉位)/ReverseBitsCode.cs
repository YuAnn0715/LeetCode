using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ReverseBitsCode:IReverseBits
    {
        //190. Reverse Bits(反轉位)
        public uint ReverseBits(uint n)
        {
            string binary = Convert.ToString(n, 2);
            List<string> strList1 = binary.Select(s => s.ToString()).ToList();
            List<string> strList2 = new List<string>();
            if (strList1.Count < 33)
            {
                for (int i = 0; i < 32 - strList1.Count; i++)
                {
                    strList2.Add("0");
                }
                foreach (string item in strList1)
                {
                    strList2.Add(item);
                }
            }
            strList2.Reverse();
            string newBinary = string.Join("", strList2);
            uint total = Convert.ToUInt32(newBinary, 2);
            return total;
        }
    }
}
