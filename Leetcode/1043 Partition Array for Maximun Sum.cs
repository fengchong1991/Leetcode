using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _1043_Partition_Array_for_Maximun_Sum
    {
        /// <summary>
        /// Use Dynamic Programming
        /// Running time O(NK)
        /// </summary>
        /// <param name="A"></param>
        /// <param name="K"></param>
        /// <returns></returns>
        public int MaxSumAfterPartitioning(int[] A, int K)
        {
            var length = A.Length;

            // Create an array to store the biggest values at each index
            var max = new int[length];

            for (var i = 0; i < length; i++)
            {
                int currentMax = 0;

                // Loop through k = 0, k = 1, .... , k = K - 1 to find the maximum sum
                for (var j = 0; j < K && i - j >= 0; j++)
                {
                    // Maximum within K indexes
                    currentMax = Math.Max(currentMax, A[i - j]);

                    // Total sum
                    max[i] = Math.Max(max[i], ((i - j - 1) >= 0 ? max[i - j - 1] : 0) + currentMax * (j + 1));
                }
            }

            return max[A.Length - 1];
        }

    }
}
