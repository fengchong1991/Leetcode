using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _977_Square_of_a_Sorted_Array
    {

        // Running time: O(NLogN), sorting takes NLogN and double takes N
        // Space: O(N)
        public int[] SortedSquares(int[] A)
        {
            var sorted = A.OrderBy(a => a);

            for (int i = 0; i < A.Length; i++)
            {
                A[i] *= A[i];
            }

            return sorted.ToArray();
        }

        public int[] SortedSquares_V2(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                A[i] *= A[i];
            }
            Array.Sort(A);
            return A;
        }


        // Running time: O(N)
        // Space: O(N)
        // Use two pointers, split the array into two arrays(negative one and positive one), merge two arrays together 
        public int[] SortedSquares_V3(int[] A)
        {
            var posIndex = 0;

            var result = new int[A.Length];

            // Find the starting index of positive sequene
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] >= 0)
                {
                    posIndex = i;
                    break;
                }
            }

            var negIndex = posIndex - 1;

            var index = 0;

            // Merge two arrays together
            while (negIndex >= 0 && posIndex < A.Length)
            {
                if (Math.Abs(A[negIndex]) < A[posIndex])
                {
                    result[index++] = A[negIndex] * A[negIndex];
                    negIndex--;
                }
                else
                {
                    result[index++] = A[posIndex] * A[posIndex];
                    posIndex++;
                }
            }

            while (negIndex >= 0)
            {
                result[index++] = A[negIndex] * A[negIndex];
                negIndex--;
            }

            while (posIndex < A.Length)
            {
                result[index++] = A[posIndex] * A[posIndex];
                posIndex++;
            }

            return result;
        }

    }
}
