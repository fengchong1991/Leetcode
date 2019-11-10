using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetcodeTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_1110()
        {

            var array = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

            var result = MaxSubArray(array);
        }

        public int MaxSubArray(int[] nums)
        {
            var largestSum = new int[nums.Length];
            largestSum[0] = nums[0];

            var max = nums[0];

            for (var i = 1; i < nums.Length; i++)
            {
                largestSum[i] = nums[i] + largestSum[i - 1] > 0 ? largestSum[i - 1] : 0;

                max = Math.Max(max, largestSum[i]);
            }

            return max;
        }


        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
    }
}
