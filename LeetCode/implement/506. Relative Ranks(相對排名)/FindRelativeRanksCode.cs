using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class FindRelativeRanksCode : IFindRelativeRanks
    {
        //506. Relative Ranks(相對排名)
        public string[] FindRelativeRanks(int[] score)
        {
            List<string> rankList = new List<string>();
            for (int i = 0; i < score.Length; i++)
            {
                int point = 0;
                for (int j = 0; j < score.Length; j++)
                {
                    if (score[i] >= score[j])
                    {
                        point++;
                    }
                }
                int rank = score.Length + 1 - point;
                rankList.Add(rank.ToString());
            }
            for (int i = 0; i < rankList.Count; i++)
            {
                string rank = rankList[i];
                int topThree = 0;
                switch (rank)
                {
                    case "1":
                        rankList[i] = "Gold Medal";
                        topThree++;
                        break;
                    case "2":
                        rankList[i] = "Silver Medal";
                        topThree++;
                        break;
                    case "3":
                        rankList[i] = "Bronze Medal";
                        topThree++;
                        break;
                    default:
                        break;
                }
                if (topThree == 3)
                {
                    break;
                }
            }
            return rankList.ToArray();
        }
    }
}
