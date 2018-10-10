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
            while (a != null && b != null)
            {
                if (a.Data != b.Data)
                {
                    return false;
                }

                a = a.Next;
                b = b.Next;
            }

            return a == null && b == null;
        }


        // Two pointers, one fast one slow. Push the first half to stack, compare it with the second half.
        public bool IsPalndrome_V2(Node a)
        {
            var stack = new Stack<int>();

            var pointer1 = a;
            var pointer2 = a;

            while (pointer2 != null && pointer2.Next != null)
            {
                stack.Push(pointer1.Data);
                pointer1 = pointer1.Next;
                pointer2 = pointer2.Next.Next;
            }

            if (pointer2 != null)
            {
                pointer1 = pointer1.Next;
            }

            while (pointer1 != null)
            {
                if (pointer1.Data != stack.Pop())
                {
                    return false;
                }
                pointer1 = pointer1.Next;
            }

            return true;
        }

        // Recursive
        public bool IsPalndrome_V3(Node a)
        {
            var length = GetNodeLength(a);
            var result = IsPalndromeRecur(a, length);
            return result.PalnResult;
        }

        public Result IsPalndromeRecur(Node a, int length)
        {
            if (a == null || length == 0)
            {
                return new Result(a, true);
            }
            else if (length == 1)
            {
                return new Result(a.Next, true);
            }

            var res = IsPalndromeRecur(a.Next, length - 2);

            if (!res.PalnResult || res.Node == null)
            {
                return res;
            }
            res.PalnResult = (a.Data == res.Node.Data);

            res.Node = res.Node.Next;
            return res;
        }

        public int GetNodeLength(Node a)
        {
            var length = 0;
            while(a != null)
            {
                length++;
                a = a.Next;
            }

            return length;
        }

        public class Result
        {
            public Node Node { get; set; }
            public bool PalnResult { get; set; }

            public Result(Node a, bool result)
            {
                Node = a;
                PalnResult = result;
            }
        }
    }
}
