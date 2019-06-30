using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _763_Partition_Labels
    {
        // Running time: O(N), N is the length of the string
        // Space: O(1), 26 partitions maximum
        public IList<int> PartitionLabels(string S)
        {

            var result = new List<int>();

            // Create a array of last index of each char
            var lastIndex = new int[26];

            for (var i = 0; i < S.Length; i++)
            {
                lastIndex[S[i] - 'a'] = i;
            }

            var last = 0;

            // Start of the current partition
            var partitionStartIndex = 0;

            for (var i = 0; i < S.Length; i++)
            {

                // Find the last of the current partition
                last = Math.Max(last, lastIndex[S[i] - 'a']);

                if (i == last)
                {
                    result.Add(i - partitionStartIndex + 1);
                    partitionStartIndex = i + 1;
                }
            }

            return result;
        }
    }
}
