using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class IntersectCode : IIntersect
    {
        //350. Intersection of Two Arrays II(兩個數組的交集 II)
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            List<int> num1List = nums1.ToList();
            List<int> num2List = nums2.ToList();
            List<int> output = new List<int>();
            //少的去檢查多的
            if (num1List.Count > num2List.Count)
            {
                for (int i = 0; i < num2List.Count; i++)
                {
                    for (int j = 0; j < num1List.Count; j++)
                    {
                        if (num2List[i] == num1List[j])
                        {
                            output.Add(num2List[i]);
                            num1List.RemoveAt(j);
                            break;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < num1List.Count; i++)
                {
                    for (int j = 0; j < num2List.Count; j++)
                    {
                        if (num1List[i] == num2List[j])
                        {
                            output.Add(num1List[i]);
                            num2List.RemoveAt(j);
                            break;
                        }
                    }
                }
            }
            return output.ToArray();
        }
    }
}
