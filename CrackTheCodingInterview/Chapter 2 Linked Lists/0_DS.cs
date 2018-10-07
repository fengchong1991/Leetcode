using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterview.Chapter_2_Linked_Lists
{
    public class Node
    {
        public int Data {get;set;}
        public Node Next { get; set; }

        public Node(int data)
        {
            Data = data;
        }


        public void AppendToTail(int data)
        {
            var node = this;
            while (node.Next != null) {
                node = node.Next;
            }

            node.Next = new Node(data);
        }

        public Node Delete(Node head, int d)
        {
            var node = head;

            if(node == null)
            {
                return null;
            }

            if (node.Data == d)
            {
                return node.Next;
            }

            while(node.Next != null)
            {
                if(node.Next.Data == d)
                {
                    node.Next = node.Next.Next;
                    return head;
                }

                node = node.Next;
            }

            return head;
        }

        public string PrintAll()
        {
            var toString = Data.ToString();

            while(Next != null)
            {
                toString += " " + Next.Data.ToString();
                Next = Next.Next;
            }

            return toString;
        }
    }
}
