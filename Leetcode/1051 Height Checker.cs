using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _1051_Height_Checker
    {
        // Running time: O(NLogN)
        // Space: O(N)
        public int HeightChecker(int[] heights)
        {

            var sortedHeights = heights.OrderBy(h => h).ToArray();

            var count = 0;

            for (int i = 0; i < heights.Length; i++)
            {
                if (heights[i] != sortedHeights[i])
                {
                    count++;
                }
            }

            return count;
        }
    }
}
