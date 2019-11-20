using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _78_Subsets
    {
        // Back tracking approach
        public IList<IList<int>> Subsets(int[] nums)
        {
            var allSubsets = new List<IList<int>>();
            var subset = new List<int>();

            FindSubsets(nums, 0, subset, allSubsets);
            return allSubsets;
        }

        public void FindSubsets(int[] nums, int index, IList<int> subset, IList<IList<int>> allSubsets)
        {

            allSubsets.Add(new List<int>(subset));

            for (var i = index; i < nums.Length; i++)
            {
                subset.Add(nums[i]);
                FindSubsets(nums, i + 1, subset, allSubsets);
                subset.RemoveAt(subset.Count - 1);
            }
        }
 
        // BFS
        // Running time O(2^N), there will be 2^N items in the end
        // Space O(2^N)
        public IList<IList<int>> Subsets(int[] nums)
        { 
            var sets = new List<IList<int>>();

            sets.Add(new List<int>());

            for (var i = 0; i < nums.Length; i++)
            {

                var length = sets.Count;

                for (var j = 0; j < length; j++)
                {
                    var set = new List<int>(sets[j]);
                    set.Add(nums[i]);
                    sets.Add(set);
                }
            }

            return sets;
        }
    }
}
