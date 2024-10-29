using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class CheckRecordCode : ICheckRecord
    {
        //551. Student Attendance Record I(學生出勤記錄 I)
        public bool CheckRecord(string s)
        { 
           int sumA = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'A')
                {
                    sumA++;
                }
                if (s[i] == 'L')
                {
                    int sumL = 0;
                    while (i < s.Length)
                    {
                        if (s[i] == 'L')
                        {
                            i++;
                            sumL++;
                        }
                        else
                        {
                            i--;
                            break;
                        }
                    }
                    if (sumL >= 3)
                    {
                        return false;
                    }
                }
            }
            if (sumA >= 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
