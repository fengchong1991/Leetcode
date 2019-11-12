using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _15_3Sum
    {

        // Sort and then two pointer
        // Sort O(NLogN), Calculate O(N^2)
        // -4 -1 -1 0 1 2
        // -2 0 0 2 2
        public IList<IList<int>> ThreeSum(int[] nums)
        {

            Array.Sort(nums);

            var list = new List<IList<int>>();

            for (var i = 0; i < nums.Length; i++)
            {

                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                var target = -nums[i];

                var startIndex = i + 1;
                var endIndex = nums.Length - 1;

                while (startIndex < endIndex)
                {
                    if ((nums[startIndex] + nums[endIndex]) == target)
                    {
                        list.Add(new List<int>() { nums[i], nums[startIndex], nums[endIndex] });
                        startIndex++;
                        endIndex--;

                        // Remove duplicates
                        while (startIndex < endIndex && nums[startIndex] == nums[startIndex - 1])
                        {
                            startIndex++;
                        }
                        while (startIndex < endIndex && nums[endIndex] == nums[endIndex + 1])
                        {
                            endIndex--;
                        }
                    }
                    else if ((nums[startIndex] + nums[endIndex]) < target)
                    {
                        startIndex++;
                    }
                    else
                    {
                        endIndex--;
                    }

                }
            }

            return list;
        }

    }
}
