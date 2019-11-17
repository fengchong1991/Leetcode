using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetcodeTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_1110()
        {

            var n1 = new ListNode(1);
            var n2 = new ListNode(2);
            var n3 = new ListNode(3);
            var n4 = new ListNode(4);
            var n5 = new ListNode(5);

            n1.next = n2;
            n2.next = n3;
            n3.next = n4;
            n4.next = n5;

            var result = ReverseKGroup(n1, 3);
        }

        public static ListNode ReverseKGroup(ListNode head, int k)
        {
            if (k <= 1 || head == null)
                return head;

            ListNode current = head, previous = null;
            while (true)
            {
                ListNode lastNodeOfPreviousPart = previous;
                // after reversing the LinkedList 'current' will become the last node of the sub-list
                ListNode lastNodeOfSubList = current;
                ListNode next = null; // will be used to temporarily store the next node
                                      // reverse 'k' nodes
                for (int i = 0; current != null && i < k; i++)
                {
                    next = current.next;
                    current.next = previous;
                    previous = current;
                    current = next;
                }

                // connect with the previous part
                if (lastNodeOfPreviousPart != null)
                    lastNodeOfPreviousPart.next = previous; // 'previous' is now the first node of the sub-list
                else // this means we are changing the first node (head) of the LinkedList
                    head = previous;

                // connect with the next part
                lastNodeOfSubList.next = current;

                if (current == null) // break, if we've reached the end of the LinkedList
                    break;
                // prepare for the next sub-list
                previous = lastNodeOfSubList;
            }

            return head;
        }


        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }


        // Definition for singly-linked list.
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
    }
}
