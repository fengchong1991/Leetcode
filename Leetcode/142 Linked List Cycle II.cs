using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _142_Linked_List_Cycle_II
    {
        public ListNode DetectCycle(ListNode head)
        {
            var slow = head;
            var fast = head;
            var circleLength = int.MinValue;

            // Find the cycle length
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                {

                    var meetNode = slow;
                    circleLength = 0;
                    do
                    {

                        meetNode = meetNode.next;
                        circleLength++;

                    }
                    while (meetNode != slow);

                    break;
                }
            }

            if (circleLength == int.MinValue)
            {
                return null;
            }

            slow = head;
            fast = head;

            // Move one pointer to cycle length position
            while (circleLength > 0)
            {
                fast = fast.next;
                circleLength--;
            }

            while (slow != fast)
            {
                slow = slow.next;
                fast = fast.next;
            }

            return slow;
        }
    }
}
