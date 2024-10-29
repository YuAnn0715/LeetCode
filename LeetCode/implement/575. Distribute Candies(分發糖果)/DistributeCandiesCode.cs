using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class DistributeCandiesCode : IDistributeCandies
    {
        //575. Distribute Candies(分發糖果)
        public int DistributeCandies(int[] candyType)
        {
            int halfCandies = candyType.Length / 2;
            // 唯一元素HashSet
            HashSet<int> uniqueCandies = new HashSet<int>();

            // 計算不同type數量
            foreach (int candy in candyType)
            {
                uniqueCandies.Add(candy);
            }

            // 取糖果種類跟一半糖果 哪個最小 return
            // 如果糖果種類比吃一半小 那怎麼吃都只會只有種類數量 吃不到一半
            // 反之  一半的數量比種類小 那怎麼吃 都只能吃一半的量
            return Math.Min(uniqueCandies.Count, halfCandies);
        }
    }
}
