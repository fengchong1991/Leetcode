using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _53_Maximum_subarray
    {
        // Running time O(N)
        public int MaxSubArray(int[] nums)
        {
            var largestSum = new int[nums.Length];
            largestSum[0] = nums[0];

            var max = nums[0];

            for (var i = 1; i < nums.Length; i++)
            {
                largestSum[i] = nums[i] + (largestSum[i - 1] > 0 ? largestSum[i - 1] : 0);

                max = Math.Max(max, largestSum[i]);
            }

            return max;
        }
    }
}
