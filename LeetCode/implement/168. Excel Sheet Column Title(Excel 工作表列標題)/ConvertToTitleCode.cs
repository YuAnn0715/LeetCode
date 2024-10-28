using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ConvertToTitleCode:IConvertToTitle
    {
        //168. Excel Sheet Column Title(Excel 工作表列標題)
        public string ConvertToTitle(int columnNumber)
        {
            StringBuilder result = new StringBuilder();
            while (columnNumber > 0)
            {
                columnNumber--;
                char letter = (char)('A' + (columnNumber % 26));
                result.Insert(0, letter);
                columnNumber /= 26;
            }
            return result.ToString();
        }
    }
}
