using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    // Running time O(N)
    class _209_Minimum_Size_Subarray_Sum
    {
        public int MinSubArrayLen(int s, int[] nums)
        {
            var startIndex = 0;
            var length = int.MaxValue;
            var sum = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                sum += nums[i];

                if (sum >= s)
                {

                    while ((sum - nums[startIndex]) >= s)
                    {
                        sum -= nums[startIndex];
                        startIndex++;
                    }

                    length = Math.Min(length, i - startIndex + 1);
                }
            }

            if (length == int.MaxValue)
            {
                length = 0;
            }

            return length;
        }
    }
}
