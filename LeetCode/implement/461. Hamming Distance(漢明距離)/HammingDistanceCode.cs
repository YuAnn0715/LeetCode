using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class HammingDistanceCode : IHammingDistance
    {
        //461. Hamming Distance(漢明距離)
        public int HammingDistance(int x, int y)
        {
            string binaryX = Convert.ToString(x, 2);
            string binaryY = Convert.ToString(y, 2);
            int Hamming = 0;
            if (binaryX.Length >= binaryY.Length)
            {
                while (binaryY.Length < binaryX.Length)
                {
                    binaryY = binaryY.Insert(0, "0");
                }
            }
            else
            {
                while (binaryY.Length > binaryX.Length)
                {
                    binaryX = binaryX.Insert(0, "0");
                }
            }
            for (int i = 0; i < binaryX.Length; i++)
            {
                if (binaryX[i] != binaryY[i])
                {
                    Hamming++;
                }
            }
            return Hamming;
        }
    }
}
