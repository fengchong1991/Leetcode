using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterview.Chapter_5_Bit_Manipulation
{
    public class _5_1
    {
        //        Insertion: You are given two 32-bit numbers, N and M, and two bit positions, i and
        //j.Write a method to insert M into N such that M starts at bit j and ends at bit i.You
        //can assume that the bits j through i have enough space to fit all of M. That is, if
        //M = 10011, you can assume that there are at least 5 bits between j and i.You would not, for
        //example, have j = 3 and i = 2, because M could not fully fit between bit 3 and bit 2.
        //EXAMPLE
        //Input: N 10000000000, M 10011, i 2, j 6

        //Output: N = 10001001100
        //Hints: #137, #769, #215

		public int BitInsert(int n, int m, int j, int i)
        {
            // Clear bits from j to i 
            int allOnes = ~0;

            var leftOnes = allOnes << j;
            var rightOnes = (1 << i) - 1;
            var mask = leftOnes | rightOnes;

            var cleared = n & mask;
            var moved = m << i;

            return n | moved;
        }
    }
}
