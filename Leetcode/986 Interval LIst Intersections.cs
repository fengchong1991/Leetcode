using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _986_Interval_LIst_Intersections
    {
        // Running time: O(M+N), M is the length of A, N is the length of B
        // Space: O(M+N)
        public int[][] IntervalIntersection(int[][] A, int[][] B)
        {

            var result = new List<int[]>();

            for (int i = 0, j = 0; i < A.Length && j < B.Length;)
            {
                var aLeft = A[i][0];
                var aRight = A[i][1];

                var bLeft = B[j][0];
                var bRight = B[j][1];

                if (aRight < bLeft)
                {
                    i++;
                    continue;
                }

                if (aLeft > bRight)
                {
                    j++;
                    continue;
                }

                result.Add(new int[] { Math.Max(aLeft, bLeft), Math.Min(aRight, bRight) });

                if (aRight > bRight)
                {
                    j++;
                }
                else if (aRight < bRight)
                {
                    i++;
                }
                else
                {
                    i++;
                    j++;
                }
            }

            return result.ToArray();
        }

        // Running time: O(M+N), M is the length of A, N is the length of B
        // Space: O(M+N)
        // Same logic, shorter code
        public int[][] IntervalIntersection_V2(int[][] A, int[][] B)
        {

            var result = new List<int[]>();

            for (int i = 0, j = 0; i < A.Length && j < B.Length;)
            {
                var low = Math.Max(A[i][0], B[j][0]);
                var high = Math.Min(A[i][1], B[j][1]);

                if (low <= high)
                {
                    result.Add(new int[] { low, high });
                }

                if (A[i][1] > B[j][1])
                {
                    j++;
                }
                else
                {
                    i++;
                }
            }

            return result.ToArray();
        }
    }
}
