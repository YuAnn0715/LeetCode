using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class CanConstructCode : ICanConstruct
    {
        //383. Ransom Note(勒索信)
        public bool CanConstruct(string ransomNote, string magazine)
        {
            for (int i = 0; i < ransomNote.Length; i++)
            {
                for (int j = 0; j < magazine.Length; j++)
                {
                    if (ransomNote[i] == magazine[j])
                    {
                        ransomNote = ransomNote.Remove(i, 1);
                        magazine = magazine.Remove(j, 1);
                        i--;
                        break;
                    }
                }
            }
            if (ransomNote.Length != 0)
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
