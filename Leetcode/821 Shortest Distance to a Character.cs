using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    // Two passes
    // Running time: O(N)
    // Space: O(N)
    public int[] ShortestToChar(string S, char C)
    {

        var distances = new int[S.Length];

        var prev = S.Length;
        for (var i = 0; i < S.Length; i++)
        {
            if (S[i] == C)
            {
                prev = i;
            }
            distances[i] = Math.Abs(i - prev);
        }


        for (var i = S.Length - 1; i >= 0; i--)
        {
            if (S[i] == C)
            {
                prev = i;
            }
            distances[i] = Math.Min(distances[i], Math.Abs(i - prev));
        }

        return distances;
    }
}
