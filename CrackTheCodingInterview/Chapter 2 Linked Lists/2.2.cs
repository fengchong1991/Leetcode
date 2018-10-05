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


    }
}
