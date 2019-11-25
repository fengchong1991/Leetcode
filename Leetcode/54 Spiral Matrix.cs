using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _54_Spiral_Matrix
    {
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

                for (var j = 0; j < n - 2 * offset; j++)
                {
                    result.Add(matrix[offset][offset + j]);
                }

                for (var i = 1; i < m - 2 * offset; i++)
                {
                    result.Add(matrix[offset + i][n - 1 - offset]);
                }

                if (m - 1 - offset != offset)
                {

                    for (var j = 1; j < n - 2 * offset; j++)
                    {
                        result.Add(matrix[m - 1 - offset][n - 1 - j - offset]);
                    }
                }

                if (n - 1 - offset != offset)
                {
                    for (var i = 1; i < m - 2 * offset - 1; i++)
                    {
                        result.Add(matrix[m - 1 - i - offset][offset]);
                    }
                }
                offset++;
            }

            return result;
        }
    }
}
