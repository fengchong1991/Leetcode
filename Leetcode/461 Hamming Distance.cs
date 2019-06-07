using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _461_Hamming_Distance
    {
        // Running time: O(1)
        public int HammingDistance(int x, int y)
        {

            var temp = x ^ y;
            var count = 0;

            while (temp != 0)
            {
                if ((temp & 1) == 1)
                {
                    count++;
                }

                temp = temp >> 1;
            }

            return count;
        }
    }
}
