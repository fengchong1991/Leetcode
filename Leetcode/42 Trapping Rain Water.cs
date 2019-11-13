using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _42_Trapping_Rain_Water
    {
        // Running time O(N)
        public int Trap(int[] height)
        {
            var result = 0;

            var leftPointer = 0;
            var rightPointer = height.Length - 1;
            var leftMost = 0;
            var rightMost = 0;


            while (leftPointer < rightPointer)
            {

                leftMost = Math.Max(leftMost, height[leftPointer]);
                rightMost = Math.Max(rightMost, height[rightPointer]);

                if (leftMost <= rightMost)
                {
                    result += leftMost - height[leftPointer];
                    leftPointer++;
                }
                else
                {
                    result += rightMost - height[rightPointer];
                    rightPointer--;
                }
            }

            return result;
        }
    }
}
