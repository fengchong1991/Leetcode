using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _442_Find_All_Duplicates_in_an_Array
    {
        /// <summary>
        /// Flip the number at nums[i]. If the number is negative, add it to the result
        /// Running time O(N), Space O(1)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public IList<int> FindDuplicates(int[] nums)
        {

            var resultList = new List<int>();

            for (var i = 0; i < nums.Length; i++)
            {

                var flipIndex = Math.Abs(nums[i]) - 1;

                if (nums[flipIndex] < 0)
                {
                    resultList.Add(Math.Abs(nums[i]));
                }

                nums[flipIndex] = -nums[flipIndex];
            }

            return resultList;
        }
    }
}
