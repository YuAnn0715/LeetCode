using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class RomanToIntCode : IRomanToInt
    {
        public int RomanToInt(string s)
        {
            Dictionary<string, int> romanNumber = new Dictionary<string, int>();
            romanNumber.Add("I", 1);
            romanNumber.Add("V", 5);
            romanNumber.Add("X", 10);
            romanNumber.Add("L", 50);
            romanNumber.Add("C", 100);
            romanNumber.Add("D", 500);
            romanNumber.Add("M", 1000);
            int romanTotal = 0;
            List<string> strSList = s.Select(c => c.ToString()).ToList();
            if (strSList.Count > 1)
            {
                for (int i = 0; i < strSList.Count - 1; i++)
                {
                    if (strSList[i] == "I" && strSList[i + 1] == "V")
                    {
                        romanTotal += 4;
                        strSList.RemoveAt(i);
                        strSList.RemoveAt(i);
                        i--;
                    }
                    else if (strSList[i] == "I" && strSList[i + 1] == "X")
                    {
                        romanTotal += 9;
                        strSList.RemoveAt(i);
                        strSList.RemoveAt(i);
                        i--;
                    }
                    else if (strSList[i] == "X" && strSList[i + 1] == "L")
                    {
                        romanTotal += 40;
                        strSList.RemoveAt(i);
                        strSList.RemoveAt(i);
                        i--;
                    }
                    else if (strSList[i] == "X" && strSList[i + 1] == "C")
                    {
                        romanTotal += 90;
                        strSList.RemoveAt(i);
                        strSList.RemoveAt(i);
                        i--;
                    }
                    else if (strSList[i] == "C" && strSList[i + 1] == "D")
                    {
                        romanTotal += 400;
                        strSList.RemoveAt(i);
                        strSList.RemoveAt(i);
                        i--;
                    }
                    else if (strSList[i] == "C" && strSList[i + 1] == "M")
                    {
                        romanTotal += 900;
                        strSList.RemoveAt(i);
                        strSList.RemoveAt(i);
                        i--;
                    }
                }
            }
            foreach (string item in strSList)
            {
                if (romanNumber.ContainsKey(item))
                {
                    int romanNumberValue = romanNumber[item];
                    romanTotal += romanNumberValue;
                }
            }
            return (romanTotal);
        }
    }
}
