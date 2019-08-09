using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _867_Transpose_Matrix
    {
        public int[][] Transpose(int[][] A)
        {
            var result = new int[A[0].Length][];

            for (var i = 0; i < A[0].Length; i++)
            {

                result[i] = new int[A.Length];

                for (var j = 0; j < A.Length; j++)
                {
                    result[i][j] = A[j][i];
                }
            }

            return result;
        }
    }
}
