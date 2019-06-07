using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _657_Robot_Return_to_Origin
    {
        // Running time: O(N)
        // Space: O(1)
        public bool JudgeCircle(string moves)
        {
            var x = 0;
            var y = 0;

            foreach (var move in moves)
            {
                switch (move)
                {
                    case 'L': x--; break;
                    case 'R': x++; break;
                    case 'U': y++; break;
                    case 'D': y--; break;
                }
            }

            return x == 0 && y == 0;
        }
    }
}
