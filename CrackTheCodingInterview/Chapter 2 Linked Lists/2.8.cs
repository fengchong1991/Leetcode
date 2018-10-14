using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterview.Chapter_2_Linked_Lists
{
    public class _2_8
    {

        //        Loop Detection: Given a circular linked list, implement an algorithm that returns the node at the
        //beginning of the loop.
        //DEFINITION
        //Circular linked list: A(corrupt) linked list in which a node's next pointer points to an earlier node, so
        //as to make a loop in the linked list.
        //EXAMPLE
        //Input:
        //Output:
        //SOLUTION
        //A - > B - > C - > D - > E - > C[the same C as earlier]
        //C

        // Use dictionary
        public Node FindLoop(Node a)
        {
            var nodeDic = new HashSet<Node>();

            while(a != null && nodeDic.Add(a))
            {
                a = a.Next;
            }

            return a;
        }

        // Fast runner and slow runner
        public Node FindLoop_V2(Node a)
        {
            // Create a faster and slower runner
            var faster = a;
            var slower = a;
            
            // Find when they collide
            while (faster != null && faster.Next != null)
            {
                faster = faster.Next.Next;
                slower = slower.Next;

                if(faster == slower)
                {
                    break;
                }
            }

            // Check errors
            if(faster == null || faster.Next == null)
            {
                return null;
            }

            // Move slower to start, they are equally far away from the loop start
            slower = a;
            while(slower != faster)
            {
                slower = slower.Next;
                faster = faster.Next;
            }

            return faster;
        }
    }
}
