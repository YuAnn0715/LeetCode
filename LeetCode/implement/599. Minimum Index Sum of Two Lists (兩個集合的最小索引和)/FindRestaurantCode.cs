using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class FindRestaurantCode : IFindRestaurant
    {
        //599. Minimum Index Sum of Two Lists (兩個集合的最小索引和)
        public string[] FindRestaurant(string[] list1, string[] list2)
        {
            Dictionary<int, Dictionary<int, string>> IndexSum = new Dictionary<int, Dictionary<int, string>>();
            int dictionaryIndex = 0;
            for (int i = 0; i < list1.Length; i++)
            {
                for (int j = 0; j < list2.Length; j++)
                {
                    if (list1[i] == list2[j])
                    {
                        if (!IndexSum.ContainsKey(dictionaryIndex))
                        {
                            IndexSum[dictionaryIndex] = new Dictionary<int, string>();
                        }
                        IndexSum[dictionaryIndex].Add(i + j, list1[i]);
                        dictionaryIndex++;
                    }
                }
            }
            int checkMinIndexSum = int.MaxValue;
            List<string> minIndexSumWords = [];
            foreach (var item in IndexSum)
            {
                int minIndexSum = item.Value.Keys.Min();
                if (checkMinIndexSum> minIndexSum)
                {
                    checkMinIndexSum = minIndexSum;
                    minIndexSumWords = item.Value.Where(n => n.Key == minIndexSum).Select(s => s.Value).ToList();
                }
                else if (minIndexSum == checkMinIndexSum)
                {
                    minIndexSumWords.AddRange(item.Value.Where(n => n.Key == minIndexSum).Select(s => s.Value));
                }
            }
            return minIndexSumWords.ToArray();
        }
    }
}
