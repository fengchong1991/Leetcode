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
            var matrix = new int[3][];



            matrix[0] = new int[] { 1, 2, 3 };
            matrix[1] = new int[] { 4, 5, 6 };
            matrix[2] = new int[] { 7, 8, 9 };

            var reuslt = SpiralOrder(matrix);

        }

        public IList<int> SpiralOrder(int[][] matrix)
        {

            var result = new List<int>();

            if (matrix.Length == 0)
            {
                return result;
            }


            var m = matrix.Length;
            var n = matrix[0].Length;

            var offset = 0;

            while (result.Count < m * n)
            {

                for (var j = offset; j < n - 2 * offset; j++)
                {
                    result.Add(matrix[offset][j]);
                }

                for (var i = offset + 1; i < m - 2 * offset; i++)
                {
                    result.Add(matrix[i][n - offset - 1]);
                }

                for (var j = m - 2 * offset - 2; j >= offset; j--)
                {
                    result.Add(matrix[m - offset - 1][j]);
                }

                for (var i = n - 2 * offset - 2; i >= offset + 1; i--)
                {
                    result.Add(matrix[i][offset]);
                }


                offset++;
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
