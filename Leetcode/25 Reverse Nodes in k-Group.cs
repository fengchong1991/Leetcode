using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _25_Reverse_Nodes_in_k_Group
    {
        //public ListNode ReverseKGroup(ListNode head, int k)
        //{

        //    ListNode prev = null;
        //    ListNode next = null;
        //    ListNode groupEnd = null;
        //    ListNode newHead = null;

        //    var current = head;
        //    var index = 0;


        //    while (index < k && current != null)
        //    {
        //        next = current.next;
        //        current.next = prev;
        //        prev = current;

        //        if (index == 0)
        //        {
        //            groupEnd = current;
        //        }

        //        if (index == k - 1 && groupEnd != null)
        //        {

        //            if (newHead == null)
        //            {
        //                newHead = current;
        //            }

        //            if (newGroup)
        //            {
        //                groupEnd.next = current;
        //            }
        //        }

        //        current = next;

        //        index++;

        //        if (index == k)
        //        {

        //            index = 0;
        //        }
        //    }

        //    return newHead ?? head;
        //}
    }
}
