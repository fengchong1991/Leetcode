﻿using System;
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
            var array = new int[5][];
            array[0] = new int[] { 3, 9, 10 };
            array[1] = new int[] { 3, 7, 15 };
            array[2] = new int[] { 5, 12, 12 };
            array[3] = new int[] { 15, 20, 10 };
            array[4] = new int[] { 19, 24, 8 };
            var a = GetSkyline(array);
        }

        public IList<IList<int>> GetSkyline(int[][] buildings)
        {
            var buildingPoints = new List<IList<int>>();

            var result = new List<IList<int>>();

            foreach (var item in buildings)
            {
                buildingPoints.Add(new List<int>() { item[0], -item[2] });
                buildingPoints.Add(new List<int>() { item[1], item[2] });
            }

            buildingPoints.Sort((a, b) =>
            {
                if (a[0] != b[0])
                {
                    return a[0].CompareTo(b[0]);
                }
                else
                {
                    return a[1] - b[1];
                }
            });

            var sortedDic = new SortedDictionary<int, int>(new DescendingComparer<int>());
            sortedDic.Add(0, 0);

            int preMax = 0;

            foreach (var bp in buildingPoints)
            {
                if (bp[1] < 0)
                {
                    if (sortedDic.ContainsKey(-bp[1]))
                    {
                        sortedDic[-bp[1]]++;
                    }
                    else
                    {
                        sortedDic.Add(-bp[1], 1);
                    }
                }
                else
                {
                    if (sortedDic.ContainsKey(bp[1]) && sortedDic[bp[1]] > 1)
                    {
                        sortedDic[bp[1]]--;
                    }
                    else
                    {
                        sortedDic.Remove(bp[1]);
                    }
                }

                var curHeight = sortedDic.First();
                if (curHeight.Key != preMax)
                {
                    result.Add(new int[] { bp[0], curHeight.Key });
                    preMax = curHeight.Key;
                }
            }

            return result;
        }

        public class DescendingComparer<T> : IComparer<T> where T : IComparable<T>
        {
            public int Compare(T x, T y) { return y.CompareTo(x); }
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }


        // Definition for singly-linked list.
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
    }
}
