using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class AddDigitsCode : IAddDigits
    {
        //258. Add Digits(添加數字)
        public int AddDigits(int num)
        {
            if (num < 10)
            {
                return num;
            }
            else
            {
                do
                {
                    int total = 0;
                    string s = num.ToString();
                    List<string> sList = s.Select(c => c.ToString()).ToList();
                    List<int> numberList = new List<int>();
                    foreach (string item in sList)
                    {
                        int number = Convert.ToInt32(item);
                        numberList.Add(number);
                    }

                    for (int i = 0; i < numberList.Count; i++)
                    {
                        total += numberList[i];
                    }
                    num = total;
                }
                while (num > 9);
                return num;
            }
        }
    }
}
