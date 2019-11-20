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
            var array = new int[] { 1, 2, 3 };
            
            var result = Permute(array);
        }

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
