using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class AddBinaryCode : IAddBinary
    {
        //67. Add Binary(新增二進位)
        public string AddBinary(string a, string b)
        {
            int carry = 0;
            int i = a.Length - 1;
            int j = b.Length - 1;
            StringBuilder result = new StringBuilder();

            while (carry > 0 || i >= 0 || j >= 0)
            {
                int sum = carry;
                if (i >= 0)
                {
                    sum += Convert.ToInt32(a[i].ToString());
                    i--;
                }
                if (j >= 0)
                {
                    sum += Convert.ToInt32(b[j].ToString());
                    j--;
                }
                carry = sum / 2;
                int digit = sum % 2;
                result.Insert(0, digit);
            }
            return result.ToString();
        }
    }
}
