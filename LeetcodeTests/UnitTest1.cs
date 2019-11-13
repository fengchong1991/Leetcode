using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetcodeTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_1110()
        {

            var array = new int[][] {
                new int[]{2,3},
                new int[]{4,5},
                new int[]{6,7},
                new int[]{8,9},
                new int[]{1,10}
            };
            var result = Merge(array);
        }

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
                if (intervals[i][0] > intervals[i - 1][1])
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


        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
    }
}
