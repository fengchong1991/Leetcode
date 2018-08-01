using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class _2_Add_Two_Numbers
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public ListNode AddTwoNumbers_V1(ListNode l1, ListNode l2)
        {
            ListNode dummyHead = new ListNode(0);
            var node = dummyHead;

            var carriage = 0;

            while (l1 != null || l2 != null)
            {
                int a = l1 == null ? 0 : l1.val;
                int b = l2 == null ? 0 : l2.val;

                var sum = a + b + carriage;

                carriage = sum / 10;

                var value = sum % 10;

                node.next = new ListNode(value);
                node = node.next;
                if (l1 != null)
                {
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    l2 = l2.next;
                }

            }

            if (carriage > 0)
            {
                node.next = new ListNode(carriage);
            }

            return dummyHead.next;
        }
    }
}
