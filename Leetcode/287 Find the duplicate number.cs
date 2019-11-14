using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _287_Find_the_duplicate_number
    {
        // Two pointer approach
        // O(N)
        public int FindDuplicate(int[] nums)
        {
            var slowPointer = nums[0];
            var fastPointer = nums[0];

            // Find the meet pointer
            do
            {

                slowPointer = nums[slowPointer];
                fastPointer = nums[nums[fastPointer]];
            }
            while (slowPointer != fastPointer);

            // Find the cycle length
            var meetPointer = slowPointer;
            var length = 0;

            do
            {
                slowPointer = nums[slowPointer];
                length++;
            }
            while (slowPointer != meetPointer);

            // Move one pointer cycle length forward
            slowPointer = nums[0];
            fastPointer = nums[0];


            while (length > 0)
            {

                fastPointer = nums[fastPointer];
                length--;
            }

            // Find when they meet
            while (slowPointer != fastPointer)
            {
                slowPointer = nums[slowPointer];
                fastPointer = nums[fastPointer];
            }


            return slowPointer;
        }
    }
}
