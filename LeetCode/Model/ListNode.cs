using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Model
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0,  ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public ListNode(params int[] values)
        {
            if (values.Length == 0)
            {
                throw new ArgumentException("Values array must contain at least one element.");
            }

            this.val = values[0];
            ListNode current = this;
            for (int i = 1; i < values.Length; i++)
            {
                current.next = new ListNode(values[i]);
                current = current.next;
            }
        }
    }


}
