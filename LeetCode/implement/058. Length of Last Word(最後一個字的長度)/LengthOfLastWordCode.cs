using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LengthOfLastWordCode : ILengthOfLastWord
    {
        //58. Length of Last Word(最後一個字的長度)
        public int LengthOfLastWord(string s)
        {
            List<string> sSplit = s.Split(" ").ToList();
            for (int i = 0; i < sSplit.Count; i++)
            {
                if (sSplit[i] == "")
                {
                    sSplit.RemoveAt(i);
                    i--;
                }
                else
                {
                    continue;
                }
            }
            string lastWord = sSplit[sSplit.Count - 1];
            int lastWordLength = lastWord.Length;
            return (lastWordLength);
        }
    }
}
