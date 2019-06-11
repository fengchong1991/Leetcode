using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _922_Sort_Array_By_Parity_II
    {

        public int[] SortArrayByParityII(int[] A)
        {
            var i = 0;
            var j = 1;

            while (i < A.Length && j < A.Length)
            {
                if (A[i] % 2 != 0 && A[j] % 2 != 1)
                {
                    var temp = A[i];
                    A[i] = A[j];
                    A[j] = temp;

                    i += 2;
                    j += 2;
                }
                else if (A[i] % 2 != 0)
                {
                    j += 2;
                }
                else if (A[j] % 2 != 1)
                {
                    i += 2;
                }
                else
                {
                    i += 2;
                    j += 2;
                }
            }

            return A;
        }
    }

    public int[] SortArrayByParityII(int[] A)
    {

        var j = 1;

        for (var i = 0; i < A.Length; i += 2)
        {
            // Swap only when i is even and A[i] is not
            if (A[i] % 2 != 0)
            {
                while (A[j] % 2 == 1)
                {
                    j += 2;
                }

                // Swap
                var temp = A[i];
                A[i] = A[j];
                A[j] = temp;
            }
        }

        return A;
    }
}
