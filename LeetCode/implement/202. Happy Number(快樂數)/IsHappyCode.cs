using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class IsHappyCode:IIsHappy
    {
        //202. Happy Number(快樂數)
        public bool IsHappy(int n)
        {
            if (n == 1)
            {
                return true;
            }
            else
            {
                List<int> happyIntList = new List<int>();
                List<string> happyStrList = new List<string>();
                do
                {
                    happyStrList.Clear();
                    happyIntList.Clear();
                    string happyStr = n.ToString();
                    happyStrList = happyStr.Select(n => n.ToString()).ToList();
                    int total = 0;
                    foreach (string item in happyStrList)
                    {
                        happyIntList.Add(int.Parse(item));
                    }
                    for (int i = 0; i < happyIntList.Count; i++)
                    {
                        int pow = Convert.ToInt32(Math.Pow(happyIntList[i], 2));
                        total += pow;
                        n = total;
                    }
                } while (n > 6);
                if (n == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
