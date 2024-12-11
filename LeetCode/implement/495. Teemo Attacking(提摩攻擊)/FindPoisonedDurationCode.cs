using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class FindPoisonedDurationCode : IFindPoisonedDuration
    {
        //495. Teemo Attacking(提摩攻擊)
        public int FindPoisonedDuration(int[] timeSeries, int duration)
        {
            int secondCount = 0;
            for (int i = 0; i < timeSeries.Length; i++)
            {
                //最後結束
                if (i == timeSeries.Length - 1)
                {
                    secondCount += duration;
                    break;
                }
                else
                {
                    if (timeSeries[i] + duration <= timeSeries[i + 1])
                    {
                        secondCount += duration;
                    }
                    else
                    {
                        //間隔
                        secondCount += timeSeries[i + 1] - timeSeries[i];
                    }
                }
            }
            return secondCount;
        }
    }
}
