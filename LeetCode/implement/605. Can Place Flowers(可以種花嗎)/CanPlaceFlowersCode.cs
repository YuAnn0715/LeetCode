using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class CanPlaceFlowersCode : ICanPlaceFlowers
    {
        // 605. Can Place Flowers(可以種花嗎)
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            if (flowerbed[0]==0)
            {

            }
            for (int i = 0; i < flowerbed.Length; i++)
            {
       
                if (flowerbed[i] == 0 & i != flowerbed.Length - 1)
                {
                    if (flowerbed[i + 1] == 0)
                    {
                        flowerbed[i + 1] = 1;
                        n--;
                        i = i + 1;
                    }
                }
            }
            if (n <= 0)
            {
                for (int i = 0; i < flowerbed.Length; i++)
                {
                    if (flowerbed[i] == 1 & i != flowerbed.Length - 1)
                    {
                        if (flowerbed[i + 1] == 1)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
