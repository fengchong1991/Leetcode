using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _46_Permutations
    {
        // BFS
        public IList<IList<int>> Permute(int[] nums)
        {
            var permutations = new Queue<IList<int>>();

            if (nums == null || nums.Length == 0)
            {
                return permutations.ToList();
            }

            permutations.Enqueue(new List<int> { nums[0] });

            for (var i = 1; i < nums.Length; i++)
            {
                var queueLength = permutations.Count;
                for (var x = 0; x < queueLength; x++)
                {
                    var permu = permutations.Dequeue();

                    for (var j = 0; j <= permu.Count; j++)
                    {
                        var newPermu = new List<int>(permu);
                        newPermu.Insert(j, nums[i]);
                        permutations.Enqueue(newPermu);
                    }
                }
            }

            return permutations.ToList();
        }

        // BackTracking
    }
}
