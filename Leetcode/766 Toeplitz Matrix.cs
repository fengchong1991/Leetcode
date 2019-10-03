using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _766_Toeplitz_Matrix
    {
        /// <summary>
        /// Running time O(M*N)
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public bool IsToeplitzMatrix(int[][] matrix)
        {
            var m = matrix.Length;
            var n = matrix[0].Length;

            // Check from top to bottom
            for (var x = 0; x < m; x++)
            {
                var i = x;
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
            for (var y = 0; y < n; y++)
            {
                var i = y;
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

        /// <summary>
        /// V2
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public bool IsToeplitzMatrix_V2(int[][] matrix)
        {
            for (var i = 0; i < matrix.Length - 1; i++)
            {
                for (var j = 0; j < matrix[0].Length - 1; j++)
                {
                    if (matrix[i][j] != matrix[i + 1][j + 1])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
