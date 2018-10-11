using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterview.Chapter_2_Linked_Lists
{

    //    Intersection: Given two(singly) linked lists, determine if the two lists intersect.Return the
    //intersecting node.Note that the intersection is defined based on reference, not value. That is, if the
    //kth node of the first linked list is the exact same node (by reference) as the jth node of the second
    //linked list, then they are intersecting.
    public class _2_7
    {
        // Store the first linked list into a hashtable, check the second linked list against it
        public Node IsIntersect(Node a, Node b)
        { 
            HashSet<Node> set = new HashSet<Node>();

            if(a == null || b == null)
            {
                return null;
            }

            while(a != null)
            {
                set.Add(a);
                a = a.Next;
            }

            while (b != null)
            {
                if (!set.Add(b))
                {
                    return b;
                }

                b = b.Next;
            }

            return null;
        }

        //
        public Node IsIntersect_V2(Node a, Node b)
        {
            if(a == null || b== null)
            {
                return null;
            }
            
            var lengthA = GetLinkedListLength(a);
            var lengthB = GetLinkedListLength(b);

            var longerList = lengthA >= lengthB ? a : b;
            var shorterList = lengthA >= lengthB ? b : a;
            
            for(var i = 0; i < Math.Abs(lengthA - lengthB); i++)
            {
                longerList = longerList.Next;
            }

            while (longerList != null)
            {
                if(longerList == shorterList)
                {
                    return longerList;
                }

                longerList = longerList.Next;
                shorterList = shorterList.Next;
            }

            return null;
        }

        public int GetLinkedListLength(Node a)
        {
            var length = 0;

            while(a != null)
            {
                length++;

                a = a.Next;
            }

            return length;
        }
    }
}
