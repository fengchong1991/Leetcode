using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _206_Reverse_linked_list
    {
        // Iterative
        // O(N)
        public ListNode ReverseList(ListNode head)
        {
            ListNode tail = null;
            var current = head;
            ListNode next = null;

            while (current != null)
            {
                next = current.next;
                current.next = tail;
                tail = current;
                current = next;
            }

            return tail;
        }

        // Recursive
        public ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            var node = ReverseList(head.next);
            head.next.next = head;
            head.next = null;

            return node;
        }
    }
}
