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
        // Running time O(N * K), N is the length of nums, K is the sum/2
        public bool CanPartition(int[] nums)
        {

            var dp = new bool?[nums.Length][];

            var sum = 0;

            foreach (var num in nums)
            {
                sum += num;
            }

            if (sum % 2 == 1)
            {
                return false;
            }

            for (var i = 0; i < dp.Length; i++)
            {
                dp[i] = new bool?[sum / 2 + 1];
            }

            return CanPartitionRecursive(dp, nums, sum / 2, 0);
        }

        public bool CanPartitionRecursive(bool?[][] dp, int[] nums, int sum, int currentIndex)
        {
            if (sum < 0)
            {
                return false;
            }

            if (sum == 0)
            {
                return true;
            }

            if (currentIndex == nums.Length)
            {
                return false;
            }

            if (dp[currentIndex][sum] == null)
            {
                dp[currentIndex][sum] = CanPartitionRecursive(dp, nums, sum - nums[currentIndex], currentIndex + 1) || CanPartitionRecursive(dp, nums, sum, currentIndex + 1);
            }

            return dp[currentIndex][sum].Value;
        }

        // Bottom up
        public bool CanPartition(int[] nums)
        {
            var sum = 0;

            foreach (var num in nums)
            {
                sum += num;
            }

            if (sum % 2 > 0)
            {
                return false;
            }

            sum = sum / 2;

            var dp = new bool[nums.Length][];

            for (var i = 0; i < dp.Length; i++)
            {
                dp[i] = new bool[sum + 1];
            }

            for (var i = 0; i < dp[0].Length; i++)
            {
                dp[0][i] = nums[0] == i || i == 0;
            }

            for (var i = 1; i < nums.Length; i++)
            {

                for (var j = 0; j <= sum; j++)
                {


                    if (dp[i - 1][j])
                    {
                        dp[i][j] = true;
                    }
                    else if (nums[i] <= j)
                    {
                        dp[i][j] = dp[i - 1][j - nums[i]];
                    }
                }
            }

            return dp[nums.Length - 1][sum];
        }
    }
}
