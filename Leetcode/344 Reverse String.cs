using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _344_Reverse_String
    {
        /// <summary>
        /// Running time O(N), space O(1)
        /// </summary>
        /// <param name="s"></param>
        public void reverseString(char[] s)
        {
            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
            {
                var temp = s[i];
                s[i] = s[j];
                s[j] = temp;
            }
        }
    }
}
