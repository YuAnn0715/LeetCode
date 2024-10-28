using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class FindComplementCode : IFindComplement
    {
        //476. Number Complement(數補碼)
        public int FindComplement(int num)
        {
            string binary = Convert.ToString(num, 2);
            string complement = "";
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '0')
                {
                    complement += "1";
                }
                else
                {
                    complement += "0";
                }
            }
            return Convert.ToInt32(complement, 2);
        }
    }
}
