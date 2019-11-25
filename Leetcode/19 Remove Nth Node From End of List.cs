using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _19_Remove_Nth_Node_From_End_of_List
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {

            var slowP = head;
            var fastP = head;

            while (n > 0)
            {
                fastP = fastP.next;
                n--;
            }

            ListNode prev = null;

            while (fastP != null)
            {
                prev = slowP;
                slowP = slowP.next;
                fastP = fastP.next;
            }

            if (prev == null)
            {
                return slowP.next;
            }
            else
            {
                prev.next = slowP.next;
            }

            return head;
        }
    }
}
