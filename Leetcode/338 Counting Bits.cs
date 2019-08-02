using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _338_Counting_Bits
    {
        // Running time: O(N*Sizeof(N))
        public int[] CountBits(int num)
        {
            var result = new int[num + 1];

            for (var i = 0; i <= num; i++)
            {

                var numberOf1 = 0;
                var value = i;

                while (value != 0)
                {
                    if ((value & 1) == 1)
                    {
                        numberOf1++;
                    }

                    value = value >> 1;
                }

                result[i] = numberOf1;
            }
            return result;
        }

        // Running time: O(N)
        public int[] CountBits_V2(int num)
        {
            var result = new int[num + 1];

            for (var i = 0; i <= num; i++)
            {
                result[i] = result[i >> 1] + (i & 1);
            }

            return result;
        }
    }
}
