using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _268_Missing_Number
    {
        // Running time O(N)
        // Space O(1)
        public int MissingNumber(int[] nums)
        {
            for (var i = 0; i < nums.Length; i++)
            {

                while (nums[i] != i && nums[i] < nums.Length)
                {

                    var temp = nums[nums[i]];
                    nums[nums[i]] = nums[i];
                    nums[i] = temp;
                }
            }

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i)
                {
                    return i;
                }
            }

            return nums.Length;
        }
    }
}
