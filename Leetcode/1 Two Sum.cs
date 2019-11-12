using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    // Running time: O(N)
    class _1_Two_Sum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {

                var key = target - nums[i];
                if (dict.ContainsKey(key))
                {
                    return new int[] { dict[key], i };
                }
                else
                {
                    dict[nums[i]] = i;
                }
            }

            return new int[0];
        }
    }
}
