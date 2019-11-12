using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    // Two pointer
    class _26_Remove_Duplicates_from_sorted_array
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            var nextNonDuplicate = 1;

            for (var i = 1; i < nums.Length; i++)
            {

                if (nums[i] != nums[i - 1])
                {
                    nums[nextNonDuplicate] = nums[i];
                    nextNonDuplicate++;
                }
            }

            return nextNonDuplicate;
        }
    }
}
