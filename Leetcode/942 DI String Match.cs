using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _942_DI_String_Match
    {
        // Running time: O(N), N is the number of chars in S
        // Space O(N), N is the number of chars
        public int[] DiStringMatch(string S)
        {
            var result = new int[S.Length + 1];

            var min = 0;
            var max = S.Length;

            for (var i = 0; i < S.Length; i++)
            {
                if (S[i] == 'I')
                {
                    result[i] = min++;
                }
                else
                {
                    result[i] = max--;
                }
            }

            result[S.Length] = min;

            return result.ToArray();
        }
    }
}
