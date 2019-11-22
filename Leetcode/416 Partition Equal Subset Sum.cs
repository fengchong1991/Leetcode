using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _416_Partition_Equal_Subset_Sum
    {

        // Brute force
        // Running time 0(2^N)
        public bool CanPartition(int[] nums)
        {

            return CalculateSum(nums, 0, 0, 0);
        }

        public bool CalculateSum(int[] nums, int index, int sum1, int sum2)
        {

            if (index == nums.Length)
            {
                return sum1 == sum2;
            }

            return CalculateSum(nums, index + 1, sum1 + nums[index], sum2) || CalculateSum(nums, index + 1, sum1, sum2 + nums[index]);
        }

        // Memorization


        public bool CanPartition(int[] nums)
        {

            Boolean[][] dp = new Boolean[nums.Length][1];
        }
    }
}
