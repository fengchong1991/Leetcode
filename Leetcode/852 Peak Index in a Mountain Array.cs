using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _852_Peak_Index_in_a_Mountain_Array
    {
        // Running time: O(N), N is the length of A
        // Space complexity: O(1)
        public int PeakIndexInMountainArray(int[] A)
        {
            for (var i = 0; i < A.Length; i++)
            {
                if (A[i] > A[i + 1])
                {
                    return i;
                }
            }

            return 0;
        }

        // Binary search
        // Running time: O(LogN)
        // Space: O(1)
        public int PeakIndexInMountainArray(int[] A)
        {

            var low = 0;
            var high = A.Length - 1;

            while (low < high)
            {
                var mid = low + (high - low) / 2;

                if (A[mid] < A[mid + 1])
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid;
                }
            }

            return low;
        }
    }
}
