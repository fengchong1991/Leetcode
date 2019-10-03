using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetcodeTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_1110()
        {
            var matrix = new int[][]
            {
               new int[] { 11, 74, 0, 93 },
               new int[] { 40, 11, 74, 7}
            };

            IsToeplitzMatrix(matrix);
        }

        public bool IsToeplitzMatrix(int[][] matrix)
        {
            var m = matrix.Length;
            var n = matrix[0].Length;

            // Check from top to bottom
            for (var i = 0; i < m; i++)
            {
                var j = 0;
                var number = matrix[i][j];

                while (i < m && j < n)
                {

                    if (number != matrix[i++][j++])
                    {
                        return false;
                    }
                }
            }


            // Check from left to right
            for (var i = 0; i < n; i++)
            {
                var j = 0;
                var number = matrix[j][i];

                while (i < n && j < m)
                {
                    if (number != matrix[j++][i++])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }


    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}
