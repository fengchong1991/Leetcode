using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _561_Array_Partition_1
    {
        public int ArrayPairSum(int[] nums)
        {
            Array.Sort(nums);

            var result = 0;

            for (var i = 0; i <= nums.Length - 2; i += 2)
            {
                result += nums[i];
            }

            return result;
        }
    }
}
