using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class FindWordsCode : IFindWords
    {
        //500. Keyboard Row(鍵盤列)
        public string[] FindWords(string[] words)
        {
            string[] rows =
            [
                "qwertyuiopQWERTYUIOP",
                "asdfghjklASDFGHJKL",
                "zxcvbnmZXCVBNM"
            ];
            List<string> answer = [];
            foreach (string word in words)
            {
                foreach (string row in rows)
                {
                    if (IsWordInRow(word, row))
                    {
                        answer.Add(word);
                        break;
                    }
                }
            }
            return answer.ToArray();
            }

        private  bool IsWordInRow(string word, string row)
        {
            foreach (char c in word)
            {
                if (!row.Contains(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
