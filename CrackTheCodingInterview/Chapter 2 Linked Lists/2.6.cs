using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterview.Chapter_2_Linked_Lists
{

    // Palindrome: Implement a function to check if a linked list is a palindrome.
    public class _2_6
    {

        // Reverse the list and compare the first half
        public bool IsPalndrome(Node a)
        {
            Node reverse = ReverseNode_V2(a);
            return IsEqual(a, reverse);
        }

        // This rearranges the original linked list
        public Node ReverseNode_V1(Node a)
        {
            var head = a;
            var tail = a;

            while (a != null)
            {
                var next = a.Next;

                a.Next = head;
                head = a;

                a = next;
            }

            tail.Next = null;

            return head;
        }

        public Node ReverseNode_V2(Node a)
        {
            Node head = null;

            while (a != null)
            {
                var node = new Node(a.Data);

                node.Next = head;
                head = node;

                a = a.Next;
            }

            return head;
        }

        public bool IsEqual(Node a, Node b)
        {
            while(a != null && b != null)
            {
                if(a.Data != b.Data)
                {
                    return false;
                }

                a = a.Next;
                b = b.Next;
            }

            return a == null && b == null;
        }


        // 
        public bool IsPalndrome_V2(Node a)
        {
            var stack = new Stack<int>();

            var pointer1 = a;
            var pointer2 = a;

            while(pointer2 != null || pointer2.Next != null)
            {
                stack.Push(pointer1.Data);
                pointer1 = pointer1.Next;
                pointer2 = pointer2.Next.Next;
            }

            if(pointer2 == null)
            {

            }
        }
    }
}
