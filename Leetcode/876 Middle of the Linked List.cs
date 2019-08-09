using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _876_Middle_of_the_Linked_List
    {
        // Use two pointers
        // Running time O(N)
        // Space O(1)
        public ListNode MiddleNode(ListNode head)
        {
            var pointer1 = head;
            var pointer2 = head;

            while (pointer2 != null && pointer2.next != null)
            {
                pointer1 = pointer1.next;
                pointer2 = pointer2.next.next;
            }

            return pointer1;
        }
    }
}
