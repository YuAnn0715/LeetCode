using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class IsValidCode : IIsValid
    {
        //20. Valid Parentheses(有效括號)
        public bool IsValid(string s)
        {
            List<string> input = s.Select(c => c.ToString()).ToList();
            if (input.Count > 1)
            {
                for (int i = 0; i < input.Count - 1; i++)
                {
                    if (input[i] == "(")
                    {
                        if (input[i + 1] == ")")
                        {
                            input.RemoveAt(i);
                            input.RemoveAt(i);
                            i = -1;
                        }
                    }
                    else if (input[i] == "[")
                    {
                        if (input[i + 1] == "]")
                        {
                            input.RemoveAt(i);
                            input.RemoveAt(i);
                            i = -1;
                        }
                    }
                    else if (input[i] == "{")
                    {
                        if (input[i + 1] == "}")
                        {
                            input.RemoveAt(i);
                            input.RemoveAt(i);
                            i = -1;
                        }
                    }
                }
                if (input.Count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
