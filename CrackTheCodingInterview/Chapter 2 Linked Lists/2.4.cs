using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterview.Chapter_2_Linked_Lists
{
    //    Partition: Write code to partition a linked list around a value x, such that all nodes less than x come
    //before all nodes greater than or equal to x.If x is contained within the list the values of x only need
    //to be after the elements less than x(see below). The partition element x can appear anywhere in the
    //"right partition"; it does not need to appear between the left and right partitions.
    //EXAMPLE
    //Input: 3 -> 5 -> 8 -> 5 -> 10 -> 2 -> 1 [partition= 5]
    //Output: 3 -> 1 -> 2 -> 10 -> 5 -> 5 -> 8
    public class _2_4
    {
        public Node PartitionLinkedList(Node a, int p)
        {

            Node leftStart = null;
            Node leftEnd = null;
            Node rightStart = null;
            Node rightEnd = null;

            while (a != null)
            {
                var node = a.Next;
                a.Next = null;

                if (a.Data >= p)
                {
                    if(rightStart == null)
                    {
                        rightStart = a;
                        rightEnd = a;
                    }
                    else
                    {
                        rightEnd.Next = a;
                        rightEnd = rightEnd.Next;
                    }
                }
                else
                {
                    if(leftStart == null)
                    {
                        leftStart = a;
                        leftEnd = a;
                    }
                    else
                    {
                        leftEnd.Next = a;
                        leftEnd = leftEnd.Next;
                    }
                }

                a = node;
            }

            if(leftStart == null)
            {
                return rightStart;
            }
            else
            {
                leftEnd.Next = rightStart;
                return leftStart;
            }
        }

        public Node PartitionLinkedList_V2(Node a, int p)
        {
            Node head = a;
            Node tail = a;

            while(a != null)
            {
                Node next = a.Next;
                if (a.Data < p)
                {
                    a.Next = head;
                    head = a;
                }
                else
                {
                    tail.Next = a;
                    tail = a;
                }
                a = next;
            }
            tail.Next = null;

            return head;
        }
    }
}
