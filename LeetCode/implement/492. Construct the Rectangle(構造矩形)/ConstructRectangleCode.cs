using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ConstructRectangleCode : IConstructRectangle
    {
        //492. Construct the Rectangle(構造矩形)
        public int[] ConstructRectangle(int area)
        {
            int w = (int)Math.Sqrt(area);
            while (area % w != 0)
            {
                w--;
            }
            return [area / w, w];
        }
    }
}
