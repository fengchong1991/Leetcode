using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _92_Reverse_Linked_List_II
    {
        public ListNode ReverseBetween(ListNode head, int m, int n)
        {
            ListNode tail = null;
            var current = head;
            ListNode next = null;

            var index = 1;

            ListNode beforeStart = null;
            ListNode end = null;
            ListNode start = null;

            while (current != null)
            {

                next = current.next;

                if (index == m - 1)
                {
                    beforeStart = current;
                }

                if (index == m)
                {
                    start = current;
                }

                if (index == n)
                {
                    end = current;
                    start.next = current.next;
                }


                if (index > m && index <= n)
                {
                    current.next = tail;
                }

                tail = current;
                current = next;

                index++;
            }

            if (beforeStart != null)
            {
                beforeStart.next = end;
                return head;
            }
            else
            {
                return end;
            }
        }


    }
}
