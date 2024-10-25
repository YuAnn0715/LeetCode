using LeetCode.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MergeTwoListsCode : IMergeTwoLists
    {
        //21. Merge Two Sorted Lists(合併兩個表)
        public ListNode? MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null)
            {
                return list2;
            }
            if (list2 == null)
            {
                return list1;
            }
            if (list1 == null && list2 == null)
            {
                return null;
            }
            ListNode result = new ListNode(0);
            ListNode current = result;

            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    list2 = list2.next;
                }
                current = current.next;
            }
            current.next = list1 ?? list2;
            return result.next;
        }
    }
}
