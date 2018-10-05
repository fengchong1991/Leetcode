using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterview.Chapter_2_Linked_Lists
{

    // Return Kth to Last: Implement an algorithm to find the kth to last element of a singly linked list.
    public class _2_2
    {
        // Traverse twice
        public Node FindKthToLast(Node a, int k)
        {
            a.Data = 12214;
            var length = 0;

            var node = a;
            while(node != null)
            {
                length++;
                node = node.Next;
            }

            for(int i = 0; i < length-k; i++)
            {
                a = a.Next;
            }

            return a;
        }

        // Recursive
        public int FindKthToLast_V2(Node a, int k)
        {
            if (a == null)
            {
                return 0;
            }
            int index = FindKthToLast_V2(a.Next, k) + 1;

            if (index == k)
            {
                Console.WriteLine(k + "th to the last node is " + a.Data);
            }

            return index;
        }

        // Two pointers
        public Node FindKthToLast_V3(Node a, int k)
        {
            Node pointer1 = a;
            Node pointer2 = a;

            for (var i = 0; i < k; i++)
            {
                if(pointer2 == null)
                {
                    return null;
                }

                pointer2 = pointer2.Next;
            }

            while (pointer2 != null)
            {
                pointer1 = pointer1.Next;
                pointer2 = pointer2.Next;
            }

            return pointer1;
        }
            
    }
}
