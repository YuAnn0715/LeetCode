using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class DetectCapitalUseCode : IDetectCapitalUse
    {
        //520. Detect Capital(檢查大寫)
        public bool DetectCapitalUse(string word)
        {
            List<char> upWord = new List<char>();
            upWord = ['A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'];
            if (upWord.Contains(word[0]))
            {
                int upSum = 1;
                for (int i = 1; i < word.Length; i++)
                {
                    if (upWord.Contains(word[i]))
                    {
                        upSum++;
                    }
                }
                if (upSum == word.Length || upSum == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                //都小寫
                for (int i = 1; i < word.Length; i++)
                {
                    if (upWord.Contains(word[i]))
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
