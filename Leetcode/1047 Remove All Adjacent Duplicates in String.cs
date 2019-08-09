using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _1047_Remove_All_Adjacent_Duplicates_in_String
    {
        // Using a stack
        // Runnign time: O(N)
        // Space: O(N)
        public string RemoveDuplicates(string S)
        {
            var stack = new Stack<char>();
            var sb = new StringBuilder();

            for (var i = 0; i < S.Length; i++)
            {

                var c = S[i];

                if (stack.Count > 0 && stack.Peek() == c)
                {
                    stack.Pop();
                    continue;
                }

                stack.Push(c);
            }

            while (stack.Count > 0)
            {
                sb.Insert(0, stack.Pop());
            }

            return sb.ToString();
        }
    }
}
