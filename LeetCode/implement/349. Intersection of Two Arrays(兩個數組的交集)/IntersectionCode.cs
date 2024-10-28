using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class IntersectionCode : IIntersection
    {
        //349. Intersection of Two Arrays(兩個數組的交集)
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            List<int> output = new List<int>();
            if (nums1.Length > nums2.Length)
            {
                for (int i = 0; i < nums2.Length; i++)
                {
                    if (nums1.Contains(nums2[i]))
                    {
                        output.Add(nums2[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < nums1.Length; i++)
                {
                    if (nums2.Contains(nums1[i]))
                    {
                        output.Add(nums1[i]);
                    }
                }
            }
            List<int> outputDistinct = output.Distinct().ToList();
            return outputDistinct.ToArray();
        }
    }
}
