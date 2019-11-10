using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _340_Longest_Substring_with_At_Most_K_Distinct_Characters
    {
        // Running time O(N)
        public int LengthOfLongestSubstringKDistinct(string s, int k)
        {

            var max = 0;
            var startIndex = 0;
            var dict = new Dictionary<char, int>();

            for (var i = 0; i < s.Length; i++)
            {

                if (dict.ContainsKey(s[i]))
                {
                    dict[s[i]]++;
                }
                else
                {
                    dict[s[i]] = 1;
                }

                while (dict.Count > k)
                {
                    if (dict.ContainsKey(s[startIndex]) && dict[s[startIndex]] > 1)
                    {
                        dict[s[startIndex++]]--;
                    }
                    else
                    {
                        dict.Remove(s[startIndex++]);
                    }
                }

                max = Math.Max(max, i - startIndex + 1);
            }

            return max;
        }
    }
}
