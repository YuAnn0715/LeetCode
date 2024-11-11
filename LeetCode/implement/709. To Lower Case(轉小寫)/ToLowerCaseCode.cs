using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ToLowerCaseCode : IToLowerCase
    {
        //709. To Lower Case(轉小寫)
        public string ToLowerCase(string s)
        {
            char[] charArray = s.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                charArray[i] = char.ToLower(charArray[i]);
            }
            return new string(charArray);
        }
    }
}
