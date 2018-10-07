using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterview.Chapter_2_Linked_Lists
{
    public class _2_5
    {
        //        Sum Lists: You have two numbers represented by a linked list, where each node contains a single
        //digit.The digits are stored in reverse order, such that the 1 's digit is at the head of the list. Write a
        //function that adds the two numbers and returns the sum as a linked list.
        //EXAMPLE
        //Input: (7-> 1 -> 6) + (5 -> 9 -> 2).That is,617 + 295.
        //Output: 2 -> 1 -> 9. That is, 912.
        //FOLLOW UP
        //Suppose the digits are stored in forward order.Repeat the above problem.
        //Input: (6 -> 1 -> 7) + (2 -> 9 -> 5).That is,617 + 295.
        //Output: 9 -> 1 -> 2. That is, 912.
        public int Sum(Node a, Node b)
        {
            var position = 1;
            var sum = 0;

            while (a != null || b != null)
            {

                var aValue = a == null ? 0 : a.Data;
                var bValue = b == null ? 0 : b.Data;

                sum += (aValue + bValue) * position;

                position *= 10;

                if (a != null)
                {
                    a = a.Next;
                }

                if (b!= null)
                {
                    b = b.Next;
                }
            }

            return sum;
            
        }
    }
}
