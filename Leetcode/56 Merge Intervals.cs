using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _56_Merge_Intervals
    {
        // Running time O(NLogN)
        public int[][] Merge(int[][] intervals)
        {
            if (intervals.Length == 0)
            {
                return new int[0][];
            }

            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

            var result = new List<int[]>();

            var start = intervals[0][0];
            var end = intervals[0][1];


            for (var i = 1; i < intervals.Length; i++)
            {
                if (intervals[i][0] > end)
                {
                    result.Add(new int[] { start, end });
                    start = intervals[i][0];
                    end = intervals[i][1];
                }
                else
                {
                    end = Math.Max(end, intervals[i][1]);
                }
            }

            result.Add(new int[] { start, end });

            return result.ToArray();
        }
    }
}
