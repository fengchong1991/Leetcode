using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _704_Binary_Search
    {
        // Running time O(logN)
        public int Search(int[] nums, int target)
        {
            var start = 0;
            var end = nums.Length - 1;


            while (start <= end)
            {
                var mid = start + (end - start) / 2;

                if (target > nums[mid])
                {
                    start = mid + 1;
                }
                else if (target < nums[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    return mid;
                }

            }

            return -1;
        }
    }
}
