using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LicenseKeyFormattingCode : ILicenseKeyFormatting
    {
        //482. License Key Formatting(許可金鑰格式化)
        public string LicenseKeyFormatting(string s, int k)
        {
            s = s.ToUpper();
            List<char> sList = s.ToList();
            for (int i = 0; i < sList.Count; i++)
            {
                if (sList[i] == '-')
                {
                    sList.RemoveAt(i);
                    i--;
                }
            }
            int quotient = sList.Count / k;
            int addcount = 0;
            if (sList.Count % k == 0)
            {
                for (int i = 1; i < quotient; i++)
                {
                    sList.Insert(k * i + addcount, '-');
                    addcount++;
                }
            }
            else
            {
                for (int i = 1; i <= quotient; i++)
                {
                    sList.Insert(sList.Count - k * i - addcount, '-');
                    addcount++;
                }
            }
            return string.Join("", sList);
        }
    }
}
