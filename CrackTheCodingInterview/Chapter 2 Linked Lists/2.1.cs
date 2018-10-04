using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterview.Chapter_2_Linked_Lists
{
    //    Remove Dups! Write code to remove duplicates from an unsorted linked list.
    //FOLLOW UP
    //How would you solve this problem if a temporary buffer is not allowed?

    public class _2_1
    {
        public void RemoveDups(Node a)
        {
            var uniqueValues = new HashSet<int>();
            Node previousNode = null;

            while(a != null)
            {
                if (uniqueValues.Contains(a.Data))
                {
                    previousNode.Next = a.Next;
                }
                else
                {
                    uniqueValues.Add(a.Data);
                    previousNode = a;
                }

                a = a.Next;
            }
        }

        public void RemoveDups_V2(Node a)
        {
            var uniqueValues = new HashSet<int>();

            if (a == null)
            {
                return;
            }

            uniqueValues.Add(a.Data);

            while (a.Next != null)
            {
                if (uniqueValues.Contains(a.Next.Data))
                {
                    a.Next = a.Next.Next;
                }
                else
                {
                    uniqueValues.Add(a.Next.Data);
                    a = a.Next;
                }
            }
        }

        // Two pointers 
        public void RemoveDups_NoBuffer(Node a)
        {        
            while(a != null)
            {
                
                var secPointer = a.Next;
                Node previosNode = a;

                while (secPointer != null) {
                    if(secPointer.Data == a.Data)
                    {
                        previosNode.Next = secPointer.Next;
                    }
                    else
                    {
                        previosNode = secPointer;
                    }

                    secPointer = secPointer.Next;
                }

                a = a.Next;
            }
        }

        public void RemoveDups_NoBuffer_V2(Node a)
        {
            while (a != null)
            {
                var secPointer = a;

                while (secPointer.Next != null)
                {
                    if (secPointer.Next.Data == a.Data)
                    {
                        secPointer.Next = secPointer.Next.Next;
                    }
                    else
                    {
                        secPointer = secPointer.Next;
                    }
                }

                a = a.Next;
            }
        }
    }
}
