using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _977_Squres_of_a_sorted_array
    {
        public int[] SortedSquares(int[] nums)
        {
            var A = new int[nums.Length];
            var startIndex = 0;
            var endIndex = nums.Length - 1;

            for (var i = nums.Length - 1; i >= 0; i--)
            {
                var start = nums[startIndex] * nums[startIndex];
                var end = nums[endIndex] * nums[endIndex];

                if (start < end)
                {
                    A[i] = end;
                    endIndex--;
                }
                else
                {
                    A[i] = start;
                    startIndex++;
                }
            }

            return A;
        }
    }
}
