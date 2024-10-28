using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TitleToNumberCode:ITitleToNumber
    {
        //171. Excel Sheet Column Number(Excel 工作表列號)
        public int TitleToNumber(string columnTitle)
        {
            string word = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int sum = 0;
            int count = 0;
            for (int i = columnTitle.Length - 1; i >= 0; i--)
            {
                int index = word.IndexOf(columnTitle[i]) + 1;
                sum += (int)Math.Pow(26, count) * index;
                count++;
            }
            return sum;
        }
    }
}
