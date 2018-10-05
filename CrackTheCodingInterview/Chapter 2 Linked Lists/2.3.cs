using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterview.Chapter_2_Linked_Lists
{
    //    Delete Middle Node: Implement an algorithm to delete a node in the middle(i.e., any node but
    //the first and last node, not necessarily the exact middle) of a singly linked list, given only access to
    //that node.
    //EXAMPLE
    //lnput:the node c from the linked list a->b->c->d->e->f
    //Result: nothing is returned, but the new linked list looks like a ->b->d- >e- >f
    public class _2_3
    {
        // Copy next node to current one and delete next
        public void DeleteNode(Node a)
        {
            if (a != null && a.Next != null)
            {
                a.Data = a.Next.Data;
                a.Next = a.Next.Next;
            }
        }
    }
}
