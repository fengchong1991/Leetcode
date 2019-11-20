using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _90_Subsets_II
    {
        // Running time O(2^N)
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {

            Array.Sort(nums);

            var result = new List<IList<int>>();
            result.Add(new List<int>());
            var lastStartIndex = 0;

            for (var i = 0; i < nums.Length; i++)
            {

                var numCount = result.Count;

                var start = 0;

                if (i > 0 && nums[i] == nums[i - 1])
                {
                    start = lastStartIndex;
                }

                for (var j = start; j < numCount; j++)
                {
                    var set = new List<int>(result[j]);
                    set.Add(nums[i]);
                    result.Add(set);
                }

                lastStartIndex = numCount;
            }

            return result;
        }
    }
}
