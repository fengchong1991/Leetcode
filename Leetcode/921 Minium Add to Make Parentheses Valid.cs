using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _921_Minium_Add_to_Make_Parentheses_Valid
    {
        // Running Time: O(N), N is the length of S
        // Space O(1)
        public int MinAddToMakeValid(string S)
        {

            var leftP = 0;
            var rightP = 0;

            foreach (var c in S)
            {
                if (c == '(')
                {
                    leftP++;
                }
                else
                {
                    if (leftP > 0)
                    {
                        leftP--;
                    }
                    else
                    {
                        rightP++;
                    }
                }
            }

            return leftP + rightP;
        }
    }
}
