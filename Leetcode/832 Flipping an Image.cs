using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _832_Flipping_an_Image
    {
        // Running time: O(N)
        // Space: O(1)
        public class Solution
        {
            public int[][] FlipAndInvertImage(int[][] A)
            {
                foreach (var array in A)
                {

                    for (int i = 0, j = array.Length - 1; i <= j; i++, j--)
                    {
                        var temp = array[i] ^ 1;
                        array[i] = array[j] ^ 1;
                        array[j] = temp;
                    }

                }

                return A;
            }
        }
    }
}
