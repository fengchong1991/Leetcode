﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class _1_Two_Sum
    {
        /// <summary>
        /// Beats 20%
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum_V1(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                int j = i + 1;
                while (j <= nums.Length - 1)
                {
                    var sum = nums[i] + nums[j];
                    if (sum == target)
                    {
                        return new int[] { i, j };
                    }
                    j++;
                }

            }

            return new int[] { 0, 0 };
        }

        /// <summary>
        /// Use a dictionary
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum_V2(int[] nums, int target)
        {
            Dictionary<int, int> numsDic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                numsDic.Add(nums[i], i);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                var num2 = target - nums[i];

                if (numsDic.ContainsKey(num2))
                {
                    return new int[] { i, numsDic[num2] };
                }
            }

            throw new Exception();
        }
        
    }
}