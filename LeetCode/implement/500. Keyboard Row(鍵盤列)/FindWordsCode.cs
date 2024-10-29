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
            string firstRow = "qwertyuiopQWERTYUIOP";
            string secondRow = "asdfghjklASDFGHJKL";
            string thirdRow = "zxcvbnmZXCVBNM";
            List<string> answer = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                if (firstRow.Contains(words[i][0]))
                {
                    int count = 0;
                    for (int j = 0; j < words[i].Length; j++)
                    {
                        if (!firstRow.Contains(words[i][j]))
                        {
                            break;
                        }
                        else
                        {
                            count++;
                        }
                        if (count == words[i].Length)
                        {
                            answer.Add(words[i]);
                        }
                    }
                }
                else if (secondRow.Contains(words[i][0]))
                {
                    int count = 0;
                    for (int j = 0; j < words[i].Length; j++)
                    {
                        if (!secondRow.Contains(words[i][j]))
                        {
                            break;
                        }
                        else
                        {
                            count++;
                        }
                        if (count == words[i].Length)
                        {
                            answer.Add(words[i]);
                        }
                    }
                }
                else if (thirdRow.Contains(words[i][0]))
                {
                    int count = 0;
                    for (int j = 0; j < words[i].Length; j++)
                    {
                        if (!thirdRow.Contains(words[i][j]))
                        {
                            break;
                        }
                        else
                        {
                            count++;
                        }
                        if (count == words[i].Length)
                        {
                            answer.Add(words[i]);
                        }
                    }
                }
            }
            return answer.ToArray();
        }
    }
}
