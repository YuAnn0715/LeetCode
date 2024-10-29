using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ConvertToBase7Code : IConvertToBase7
    {
        //504 Base 7(基礎7)
        public string ConvertToBase7(int num)
        {
            if (num == 0) return "0";
            bool isNegative = num < 0;
            num = Math.Abs(num);
            List<string> convertToBase7 = [];
            while (num > 0)
            {
                int remainder = num % 7;
                convertToBase7.Insert(0, remainder.ToString());
                num /= 7;
            }
            string result = string.Join("", convertToBase7);
            return isNegative ? "-" + result : result;
        }
    }
}
