using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _34_Find_First_and_Last_Position_of_Element_in_Sorted_Array
    {
        // Binary search
        public int[] SearchRange(int[] nums, int target)
        {
            var startIndex = Search(nums, target, true);
            var endIndex = Search(nums, target, false);

            return new int[] { startIndex, endIndex };
        }

        public int Search(int[] nums, int target, bool findStart)
        {

            var start = 0;
            var end = nums.Length - 1;
            var index = -1;

            while (start <= end)
            {
                var mid = start + (end - start) / 2;


                if (target > nums[mid])
                {
                    start = mid + 1;
                }
                else if (target < nums[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    index = mid;

                    if (findStart)
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }
            }

            return index;
        }
    }
}
